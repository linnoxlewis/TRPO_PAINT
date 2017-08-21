using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PaintOVV.GUI;
using PaintOVV.Shapes;

namespace PaintOVV.Controls
{
    /// <summary>
    /// Changing class sizes shapes and moving it on the form
    /// </summary>
    public class MoveResize : ICommand
    {

        #region Properties

        private readonly DrawHandlers _drawHandlers;
        private readonly MainForm _mainForm;
        private readonly List<List<IShape>> _currentLists = new List<List<IShape>>();
        private readonly List<List<IShape>> _previousLists = new List<List<IShape>>();
        private string _operationName;
        public int PolygonPoint;

        #endregion

        public MoveResize(DrawHandlers drawHandlers, MainForm mainForm)
        {
            _drawHandlers = drawHandlers;
            _mainForm = mainForm;
        }

       
        public void Execute(Graphics g, MouseEventArgs e, IShape tempShape)
        {
            _operationName = "Перемещение/ИзменениеРазмера";
            switch (_drawHandlers.ShapeSelection.NodeSelected)
            {
                case Enumerations.Positions.LeftUp:
                    tempShape.StartOrigin = new Point(tempShape.StartOrigin.X + e.X - _drawHandlers.StartPoint.X, tempShape.StartOrigin.Y);
                    tempShape.Width -= e.X - _drawHandlers.StartPoint.X;
                    tempShape.StartOrigin = new Point(tempShape.StartOrigin.X, tempShape.StartOrigin.Y + e.Y - _drawHandlers.StartPoint.Y);
                    tempShape.Height -= e.Y - _drawHandlers.StartPoint.Y;
                    break;

                case Enumerations.Positions.LeftMiddle:
                    tempShape.StartOrigin = new Point(tempShape.StartOrigin.X + e.X - _drawHandlers.StartPoint.X, tempShape.StartOrigin.Y);
                    tempShape.Width -= (e.X - _drawHandlers.StartPoint.X);
                    break;

                case Enumerations.Positions.LeftBottom:
                    tempShape.Width -= e.X - _drawHandlers.StartPoint.X;
                    tempShape.StartOrigin = new Point(tempShape.StartOrigin.X + e.X - _drawHandlers.StartPoint.X, tempShape.StartOrigin.Y);
                    tempShape.Height += e.Y - _drawHandlers.StartPoint.Y;
                    break;

                case Enumerations.Positions.BottomMiddle:
                    tempShape.Height += e.Y - _drawHandlers.StartPoint.Y;
                    break;

                case Enumerations.Positions.RightUp:
                    tempShape.Width += e.X - _drawHandlers.StartPoint.X;
                    tempShape.StartOrigin = new Point(tempShape.StartOrigin.X, tempShape.StartOrigin.Y + e.Y - _drawHandlers.StartPoint.Y);
                    tempShape.Height -= e.Y - _drawHandlers.StartPoint.Y;
                    break;

                case Enumerations.Positions.RightBottom:
                    tempShape.Width += e.X - _drawHandlers.StartPoint.X;
                    tempShape.Height += e.Y - _drawHandlers.StartPoint.Y;
                    break;

                case Enumerations.Positions.RightMiddle:
                    tempShape.Width += e.X - _drawHandlers.StartPoint.X;
                    break;

                case Enumerations.Positions.UpMiddle:
                    tempShape.StartOrigin = new Point(tempShape.StartOrigin.X, tempShape.StartOrigin.Y + e.Y - _drawHandlers.StartPoint.Y);
                    tempShape.Height -= e.Y - _drawHandlers.StartPoint.Y;
                    break;

                case Enumerations.Positions.LeftLinePoint:
                    tempShape.StartOrigin = new Point(tempShape.StartOrigin.X + e.X - _drawHandlers.StartPoint.X, tempShape.StartOrigin.Y);
                    tempShape.Width -= e.X - _drawHandlers.StartPoint.X;
                    tempShape.StartOrigin = new Point(tempShape.StartOrigin.X, tempShape.StartOrigin.Y + e.Y - _drawHandlers.StartPoint.Y);
                    tempShape.Height -= e.Y - _drawHandlers.StartPoint.Y;
                    break;

                case Enumerations.Positions.RightLinePoint:
                    tempShape.EndOrigin = new Point(tempShape.EndOrigin.X + e.X - _drawHandlers.StartPoint.X, tempShape.EndOrigin.Y);
                    tempShape.Width -= e.X - _drawHandlers.StartPoint.X;
                    tempShape.EndOrigin = new Point(tempShape.EndOrigin.X, tempShape.EndOrigin.Y + e.Y - _drawHandlers.StartPoint.Y);
                    tempShape.Height -= e.Y - _drawHandlers.StartPoint.Y;
                    break;

                case Enumerations.Positions.PolygonPoint:
                    var pointsArrayList = new List<Point>(tempShape.PointsArray.ToList());
                    if (tempShape.PointsArray.Length > PolygonPoint)
                    {
                        pointsArrayList[PolygonPoint] = new Point(tempShape.PointsArray[PolygonPoint].X + e.X - _drawHandlers.StartPoint.X,
                            tempShape.PointsArray[PolygonPoint].Y + e.Y - _drawHandlers.StartPoint.Y);
                    }
                    tempShape.PointsArray = new List<Point>(pointsArrayList).ToArray();
                    break;

                default:
                    if (_drawHandlers.MMove)
                    {
                        tempShape.StartOrigin = new Point(tempShape.StartOrigin.X + e.X - _drawHandlers.StartPoint.X,
                            tempShape.StartOrigin.Y + e.Y - _drawHandlers.StartPoint.Y);
                        tempShape.EndOrigin = new Point(tempShape.EndOrigin.X + e.X - _drawHandlers.StartPoint.X,
                            tempShape.EndOrigin.Y + e.Y - _drawHandlers.StartPoint.Y);
                        if (tempShape.PointsArray != null)
                        {
                            var points = new List<Point>();
                            for (var i = tempShape.PointsArray.Length - 1; i > -1; i--)
                            {
                                points.Add(new Point(tempShape.PointsArray[i].X + e.X - _drawHandlers.StartPoint.X,
                                    tempShape.PointsArray[i].Y + e.Y - _drawHandlers.StartPoint.Y));
                            }
                            tempShape.PointsArray = new List<Point>(points).ToArray();
                        }
                        _mainForm.GraphicPanel.Cursor = Cursors.SizeAll;
                    }
                    break;
            }
        }


        public void Undo()
        {
            if (_previousLists.Count > 0)
            {
                _drawHandlers.ShapesList = new List<IShape>(_previousLists[_previousLists.Count - 1]);
                _currentLists.Add(_previousLists[_previousLists.Count - 1]);
                _previousLists.Remove(_previousLists[_previousLists.Count - 1]);
            }
        }

        /// <summary>
        /// Redo changing shape
        /// </summary>
        public void Redo()
        {
            if (_currentLists.Count > 0)
            {
                _previousLists.Add(_currentLists[_currentLists.Count - 1]);
                _currentLists.Remove(_currentLists[_currentLists.Count - 1]);
                _drawHandlers.ShapesList = new List<IShape>(_currentLists[_currentLists.Count - 1]);
            }
        }

        /// <summary>
        /// Name of the operation
        /// </summary>
        /// <returns></returns>
        public string Operation()
        {
            return _operationName;
        }

        /// <summary>
        /// Update undo lists
        /// </summary>
        public void ExecuteUndo()
        {
            var undoShapesList = new List<IShape>(_drawHandlers.CopiedShapes);
            _previousLists.Add(undoShapesList);
        }

        /// <summary>
        /// Update redo lists
        /// </summary>
        public void ExecuteRedo()
        {
            var redoShapesList = new List<IShape>(_drawHandlers.ShapesList);
            _currentLists.Add(redoShapesList);
        }


        public void IncrementCurrentLists()
        {
            if (_currentLists.Count > 1)
            {
                _currentLists.Remove(_currentLists[_currentLists.Count - 2]);
            }
        }
    }
}