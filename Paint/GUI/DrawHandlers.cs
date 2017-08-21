using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using PaintOVV.Controls;
using PaintOVV.Enumerations;
using PaintOVV.Shapes;

namespace PaintOVV.GUI
{
    
    public class DrawHandlers
    {

#region Properties

        private readonly MainForm _mainForm;
        private bool _paintMode;
        private bool _hasShapes;
        private bool _mIsClick;
        private int _moveCount;
        private Point _startPoint;
        private Point _endPoint;

        public int ShapeWidth { get; set; }
        public int ShapeHeight { get; set; }
        public int ShapeSize { get; set; } = 1;
        public IShape Figure { get; set; }
        public List<IShape> CopiedShapes = new List<IShape>();
        public List<IShape> ShapesList { set; get; } = new List<IShape>();
        public DashStyle PenStyle { get; set; } = DashStyle.Solid;
        public Color ChosenColor { set; get; } = Color.Black;
        public Color FillColor { set; get; } = Color.Empty;
        public bool MMove { set; get; }
        public MoveResize MoveResize { get; }
        public int? IndexOfSelectedShape { set; get; }
        public List<IShape> Redo { get; } = new List<IShape>();
        public List<ICommand> Commands { set; get; } = new List<ICommand>();

        #endregion

        public DrawHandlers(MainForm mainForm)
        {
            _mainForm = mainForm;
            ShapeSelection = new ShapeSelection(this);
            MoveResize = new MoveResize(this, _mainForm);
            DrawShape = new DrawShape(this);
        }

        public Point StartPoint
        {
            set { _startPoint = value; }
            get { return _startPoint; }
        }
        public Point EndPoint
        {
            set { _endPoint = value; }
            get { return _endPoint; }
        }
        public ShapesEnum ShapesEnum { get; set; }
        public DrawShape DrawShape { get; }
        public ShapeSelection ShapeSelection { get; }
        
        public void pnlGraphic_Paint(object sender, PaintEventArgs e)
        {
            if (_hasShapes && ShapesList != null)
            {
                
                foreach (IShape shape in ShapesList)
                {
                    if (shape == null)
                    {
                        continue;
                    }
                    shape.Draw(e.Graphics);
                }
            }
            if (_mainForm.LoadedFile || _mainForm.SelectionMode || _mainForm.RectSelectionMode)
            {
                if (ShapesList != null) 
                    foreach (IShape shape in ShapesList)
                    {
                       // if (shape == null) continue;
                        shape.Draw(e.Graphics);
                    }
            }
            if (_hasShapes && ShapesList != null)
                {
                for (int i = ShapesList.Count - 1; i >= 0; i--)
                {
                    if (ShapesList[i] == null)
                    {
                        return;
                    }
                    if ((!_mainForm.SelectionMode || !ShapesList[i].GetShapeIsSelected()) &&
                        (!ShapesList[i].GetShapeIsSelected() || !_mainForm.RectSelectionMode)) continue;
                    switch (ShapesList[i].ShapeName)
                    {
                        case "Line":
                            ShapeSelection.LineSelection = true;
                            ShapeSelection.PolygonSelection = false;
                            break;
                        case "Polygon":
                            ShapeSelection.LineSelection = false;
                            ShapeSelection.PolygonSelection = true;
                            break;
                        default:
                            ShapeSelection.LineSelection = false;
                            ShapeSelection.PolygonSelection = false;
                            break;
                    }
                    if (ShapesList == null) continue;
                    if (IndexOfSelectedShape != null) ShapeSelection.MakeSelectionOfShape(ShapesList[i], e.Graphics);
                }
            }

            if (_paintMode)
            {
                Figure?.Draw(e.Graphics);
            }
        }

       
        public void pnlGraphic_MouseDown(object sender, MouseEventArgs e)
        {
            _mIsClick = true;
            if (_mainForm.RectSelectionMode && ShapesList.Count == 0)
            {
                MessageBox.Show(@"No figures for selection!");
            }
            else if (_mainForm.SelectionMode && ShapesList.Count != 0)
            {
                for (int i = ShapesList.Count - 1; i >= 0; i--)
                {
                    if (!ShapesList[i].ContainsPoint(e.Location)) continue;
                    ProccessOfSelectionFigure(i);
                }
                if (IndexOfSelectedShape != null && _mainForm.MoveSelectionMode && ShapesList[IndexOfSelectedShape.Value].GetShapeIsSelected())
                {
                    ShapeSelection.NodeSelected = Positions.None;
                    ShapeSelection.NodeSelected = ShapeSelection.SupportPoints.GetNodeSelectable(e.Location);
                }
            }
            else if (!_mainForm.SelectionMode)
            {
                _paintMode = true;
                if (ShapesEnum == ShapesEnum.Polygon)
                {
                    MMove = false;
                    DrawShape.Execute(null, e, null);
                }
                else if (DrawShape.CompletedPolygon)
                {
                    DrawShape.CompletePolygon();
                }
            }
            _startPoint.X = e.X;
            _startPoint.Y = e.Y;
            _mainForm.GraphicPanel.Invalidate();
        }
    

       
        public void pnlGraphic_MouseUp(object sender, MouseEventArgs e)
        {

            _paintMode = false;
            _moveCount = 0;
            if (!_mainForm.SelectionMode && !_mainForm.RectSelectionMode && !_mainForm.MoveSelectionMode && (e.X - _startPoint.X != 0
                    || e.X - _startPoint.X == 0 && ShapesEnum == ShapesEnum.Polygon || !DrawShape.CompletedPolygon))
            {
                CopyListOfFigures();
                DrawShape.ExecuteUndo();
                Commands.Add(DrawShape);
                ShapesList.Add(Figure);
                if (ShapesEnum == ShapesEnum.SelectRectangle)
                {
                    ShapesList.Remove(ShapesList[ShapesList.Count - 1]);
                    Commands.Remove(Commands[Commands.Count - 1]);
                }
                _hasShapes = true;
            }
            if (_mainForm.RectSelectionMode && ShapesList.Count != 0)
            {
                bool selectionFlag = false;
                for (int i = ShapesList.Count - 1; i >= 0; i--)
                {
                    if (!ShapesList[i].ContainsPoint(e.Location)) continue;
                    selectionFlag = true;
                    ProccessOfSelectionFigure(i);
                }
                if (!selectionFlag && !_mainForm.MoveSelectionMode)
                {
                    _mainForm.UnselectShapes.UnselectAllShapes();
                }
            }
            _mIsClick = false;
            MMove = false;
            Figure = null;
            _mainForm.UndoListAddElements();
            _mainForm.GraphicPanel.Invalidate();
        }


        public void pnlGraphic_MouseMove(object sender, MouseEventArgs e)
        {
            MMove = true;
            if (_paintMode)
            {
                _endPoint.X = e.X;
                _endPoint.Y = e.Y;
                ShapeWidth = e.X - _startPoint.X;
                ShapeHeight = e.Y - _startPoint.Y;
                ShapeSize = (int) _mainForm.numSize.Value;
                var absShapeWidth = Math.Abs(ShapeWidth);
                var absShapeHeight = Math.Abs(ShapeHeight);
                DrawShape.SetShapeParameters(absShapeWidth, absShapeHeight);
                DrawShape.Execute(null, e, null);
            }
            else if (_mainForm.MoveSelectionMode)
            {
                if (IndexOfSelectedShape != null && ShapesList[IndexOfSelectedShape.Value].ShapeName != "Polygon"
                    && ShapesList[IndexOfSelectedShape.Value].GetShapeIsSelected())
                {
                    _mainForm.GraphicPanel.Cursor = ShapeSelection.SupportPoints.GetCursor(ShapeSelection.SupportPoints.GetNodeSelectable(e.Location));
                }
                else
                {
                    _mainForm.GraphicPanel.Cursor = ShapeSelection.SupportPoints.GetCursor(ShapeSelection.SupportPoints.GetCursorOfPolygonPoint(e.Location));
                }
                if (_mIsClick == false) { return; }
                if (IndexOfSelectedShape != null && (ShapesList[IndexOfSelectedShape.Value].GetShapeIsSelected()))
                {
                    for (int i = ShapesList.Count - 1; i >= 0; i--)
                    {
                        if (!ShapesList[i].GetShapeIsSelected()) continue;
                        if (IndexOfSelectedShape == null) continue;
                        MoveResize.Execute(null, e, ShapesList[i]);
                        MoveResize.IncrementCurrentLists();
                        MoveResize.ExecuteRedo();
                        if (_moveCount == 0)
                        {
                            Commands.Add(MoveResize);
                            CopyListOfFigures();
                            MoveResize.ExecuteUndo();
                        }
                        Commands.Remove(Commands[Commands.Count - 1]);
                        Commands.Add(MoveResize);
                        _moveCount++;
                    }
                }
                _startPoint.X = e.X;
                _startPoint.Y = e.Y;
            }
            else if (_mainForm.RectSelectionMode && _startPoint.X != 0 && _startPoint.Y != 0 && _endPoint.X != 0 && _endPoint.Y != 0)
            {
                bool selectionFlag = false;
                for (var i = ShapesList.Count - 1; i >= 0; i--)
                {
                    if (!ShapesList[i].ContainsSelectedFigure(_startPoint, _endPoint)) continue;
                    selectionFlag = true;
                    ProccessOfSelectionFigure(i);
                }
                if (!selectionFlag)
                {
                    _mainForm.UnselectShapes.UnselectAllShapes();
                    RefreshPoints();
                }
            }

            _mainForm.GraphicPanel.Invalidate();
        }

      
        public void LineStyle()
        {
            if (_mainForm.radioSolid.Checked)
            {
                PenStyle = DashStyle.Solid;
            }
            else if (_mainForm.radioDash.Checked)
            {
                PenStyle = DashStyle.Dash;
            }
            else if (_mainForm.radioDot.Checked)
            {
                PenStyle = DashStyle.Dot;
            }
        }

       
        public void RefreshPoints()
        {
            _startPoint.X = 0;
            _startPoint.Y = 0;
            _endPoint.X = 0;
            _endPoint.Y = 0;
        }

        public void CopyListOfFigures()
        {
            CopiedShapes.Clear();
            for (int i = ShapesList.Count - 1; i >= 0; i--)
            {
                if (ShapesList[i] == null) continue;
                var a = ShapesList[i].Clone();
                CopiedShapes.Add(a);
            }
        }
        
        
        public void UpdateSelectedShapes()
        {
            if (IndexOfSelectedShape != null && ShapesList[IndexOfSelectedShape.Value].GetShapeIsSelected())
            {
               _mainForm.UpdateShape.Execute(null, null, null);
                Commands.Add(_mainForm.UpdateShape);
                _mainForm.GraphicPanel.Invalidate();
                _mainForm.UndoListAddElements();
            }
            _mainForm.GraphicPanel.Invalidate();
        }


        public void DeletePolyLines()
        {
            if (DrawShape.PolyLinesCount == 0) return;
            do
            {
                DrawShape.PolyLinesCount--;
               
            } while (DrawShape.PolyLinesCount > 0);
        }

        private void ProccessOfSelectionFigure(int i)
        {
            if (!_mainForm.MoveSelectionMode)
            {
                ShapesList[i].SetShapeIsSelected(true);
            }
            IShape tempShape = ShapesList[i];
            if (ShapesList.Count == 2 && tempShape != ShapesList[ShapesList.Count - 1])
            {
                ShapesList[i] = ShapesList[i + 1];
                ShapesList[i + 1] = tempShape;
            }
            else if (ShapesList.Count > 2 && tempShape != ShapesList[ShapesList.Count - 1])
            {
                for (var j = i; j < ShapesList.Count - 1; j++)
                {
                    ShapesList[j] = ShapesList[j + 1];
                }
                ShapesList[ShapesList.Count - 1] = tempShape;
            }
            IndexOfSelectedShape = ShapesList.Count - 1;
            MMove = true;
        }
    }
}