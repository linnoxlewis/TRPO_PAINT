using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using PaintOVV.Enumerations;
using PaintOVV.GUI;
using PaintOVV.Shapes;

namespace PaintOVV.Controls
{
  
    public class DrawShape : ICommand
    {

#region Properties

        private readonly DrawHandlers _drawHandlers;
        private readonly List<Point> _newPolygon = new List<Point>();
        private readonly List<List<IShape>> _currentLists = new List<List<IShape>>();
        private readonly List<List<IShape>> _previousLists = new List<List<IShape>>();

        private string _operationName;
        private int _absShapeWidth;
        private int _absShapeHeight;
        private bool _drawPolygon;

        public bool CompletedPolygon { get; set; }
        public int PolyLinesCount { get; set; }

#endregion

       
        public DrawShape(DrawHandlers drawHandlers)
        {
            _drawHandlers = drawHandlers;
        }

       
        public void SetShapeParameters(int absShapeWidth, int absShapeHeight)
        {
            _absShapeWidth = absShapeWidth;
            _absShapeHeight = absShapeHeight;
        }

       
        public void Execute(Graphics g, MouseEventArgs e, IShape tempShape)
        {
            Point tempStartPoint;
            _drawHandlers.LineStyle();
            if (_drawHandlers.ShapesEnum == ShapesEnum.Ellipse || _drawHandlers.ShapesEnum == ShapesEnum.Rectangle ||
                _drawHandlers.ShapesEnum == ShapesEnum.Triangle || _drawHandlers.ShapesEnum == ShapesEnum.SelectRectangle)
            {
                if (_drawHandlers.ShapeWidth >= 0 || _drawHandlers.ShapeHeight >= 0)
                {
                    if (_drawHandlers.ShapeWidth < 0 && _drawHandlers.ShapeHeight > 0)
                    {
                        tempStartPoint = new Point(_drawHandlers.StartPoint.X - _absShapeWidth, _drawHandlers.StartPoint.Y);
                    }
                    else if (_drawHandlers.ShapeWidth > 0 && _drawHandlers.ShapeHeight < 0)
                    {
                        tempStartPoint = new Point(_drawHandlers.StartPoint.X, _drawHandlers.StartPoint.Y - _absShapeHeight);
                    }
                    else { tempStartPoint = new Point(_drawHandlers.StartPoint.X, _drawHandlers.StartPoint.Y); }
                }
                else
                {
                    tempStartPoint = new Point(_drawHandlers.StartPoint.X - _absShapeWidth, _drawHandlers.StartPoint.Y - _absShapeHeight);
                }
                if (_drawHandlers.ShapesEnum == ShapesEnum.Ellipse)
                {
                    _drawHandlers.Figure = new Ellipse(tempStartPoint, _absShapeWidth, _absShapeHeight, _drawHandlers.ChosenColor,
                        _drawHandlers.FillColor, _drawHandlers.ShapeSize, _drawHandlers.PenStyle, false);
                    _operationName = "ДобавлениеФигуры";
                }
                if (_drawHandlers.ShapesEnum == ShapesEnum.Rectangle)
                {
                    _drawHandlers.Figure = new Shapes.Rectangle(tempStartPoint, _absShapeWidth, _absShapeHeight, _drawHandlers.ChosenColor,
                        _drawHandlers.FillColor, _drawHandlers.ShapeSize, _drawHandlers.PenStyle, false);
                    _operationName = "ДобавлениеФигуры";
                }
                if (_drawHandlers.ShapesEnum == ShapesEnum.Triangle)
                {
                    _drawHandlers.Figure = new Triangle(tempStartPoint, _absShapeWidth, _absShapeHeight, _drawHandlers.ChosenColor,
                        _drawHandlers.FillColor, _drawHandlers.ShapeSize, _drawHandlers.PenStyle, false);
                    _operationName = "ДобавлениеФигуры";
                }
                if (_drawHandlers.ShapesEnum == ShapesEnum.SelectRectangle)
                {
                    _drawHandlers.Figure = new Shapes.Rectangle(tempStartPoint, _absShapeWidth, _absShapeHeight, Color.Blue, 
                        Color.Empty, 1, DashStyle.Dash, false);
                }
            }
            else if (_drawHandlers.ShapesEnum == ShapesEnum.Line)
            {
                tempStartPoint = _drawHandlers.StartPoint;
                Point tempEndPoint = _drawHandlers.EndPoint;
                _drawHandlers.Figure = new Line(tempStartPoint, tempEndPoint, _drawHandlers.ChosenColor, _drawHandlers.ShapeSize,
                    _drawHandlers.PenStyle, false, 
                    _absShapeWidth, _absShapeHeight);
                _operationName = "ДобавлениеФигуры";
            }
            else if (_drawHandlers.ShapesEnum == ShapesEnum.Polygon)
            {
                if (_drawHandlers.MMove) return;
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        _newPolygon.Add(new Point(e.X, e.Y));
                        if (_newPolygon.Count > 0)
                        {
                            _drawPolygon = false;
                            CompletedPolygon = true;
                            _drawHandlers.Figure = new Polygon(_newPolygon.ToArray(), Color.Green, Color.Empty, 1, _drawHandlers.PenStyle, 
                                false, _drawPolygon);
                            PolyLinesCount++;
                        }
                        break;

                    case MouseButtons.Right:
                        CompletePolygon();
                        break;
                }
            }
            else if (_drawHandlers.ShapesEnum == ShapesEnum.None) { }
            else { throw new ArgumentOutOfRangeException(); }
        }

        public void CompletePolygon()
        {
            if (_newPolygon.Count > 1)
            {
                _drawPolygon = true;
                CompletedPolygon = false;
                _drawHandlers.DeletePolyLines();
                PolyLinesCount = 0;
                _drawHandlers.Figure = new Polygon(_newPolygon.ToArray(), _drawHandlers.ChosenColor, _drawHandlers.FillColor, 
                    _drawHandlers.ShapeSize, _drawHandlers.PenStyle, false, _drawPolygon);
                _newPolygon.Clear();
                _operationName = "ДобавлениеФигуры";
            }
            else
            {
                MessageBox.Show(@"Need more points");
            }
        }

        public string Operation()
        {
            return _operationName;
        }

        public void Undo()
        {
            if (_previousLists.Count > 0)
            {
                _currentLists.Add(_drawHandlers.ShapesList);
                _drawHandlers.ShapesList = new List<IShape>(_previousLists[_previousLists.Count - 1]);
                _previousLists.Remove(_previousLists[_previousLists.Count - 1]);
            }
        }

        
        public void Redo()
        {
            if (_currentLists.Count > 0)
            {
                _previousLists.Add(_drawHandlers.ShapesList);
                _drawHandlers.ShapesList = new List<IShape>(_currentLists[_currentLists.Count - 1]);
                _currentLists.Remove(_currentLists[_currentLists.Count - 1]);
            }
        }

        public void ExecuteUndo()
        {
            var undoShapesList = new List<IShape>(_drawHandlers.CopiedShapes);
            _previousLists.Add(undoShapesList);
        }

        
        public void ExecuteRedo()
        {
            var redoShapesList = new List<IShape>(_drawHandlers.ShapesList);
            _currentLists.Add(redoShapesList);
        }


    }
}