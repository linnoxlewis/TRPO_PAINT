using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PaintOVV.GUI;
using PaintOVV.Shapes;

namespace PaintOVV.Controls
{
   
    public class Copy : ICommand
    {
        private readonly DrawHandlers _drawHandlers;
        private readonly List<List<IShape>> _redoLists = new List<List<IShape>>();
        private readonly List<List<IShape>> _undoLists = new List<List<IShape>>();
        private string _operationName;

        public Copy(DrawHandlers drawHandlers)
        {
            _drawHandlers = drawHandlers;
        }

      
        public void Execute(Graphics g, MouseEventArgs e, IShape tempShape)
        {
            List<IShape> copiedShapes = new List<IShape>();
            for (int i = _drawHandlers.ShapesList.Count - 1; i >= 0; i--)
            {
                if (_drawHandlers.IndexOfSelectedShape != null && _drawHandlers.ShapesList[i].GetShapeIsSelected()
                    && _drawHandlers.IndexOfSelectedShape != null)
                {
                    _drawHandlers.ShapesList[i].SetShapeIsSelected(false);
                    var copiedShape = _drawHandlers.ShapesList[i].Clone();
                    Point a = Point.Empty;
                    a.X = copiedShape.StartOrigin.X + 15;
                    a.Y = copiedShape.StartOrigin.Y + 15;
                    if (_drawHandlers.ShapesList[i].ShapeName == "Polygon")
                    {
                        var pointsArrayList = new List<Point>();
                        for (int j = _drawHandlers.ShapesList[i].PointsArray.Length - 1; j >= 0; j--)
                        {
                            Point b = Point.Empty;
                            b.X = _drawHandlers.ShapesList[i].PointsArray[j].X + 30;
                            b.Y = _drawHandlers.ShapesList[i].PointsArray[j].Y + 30;
                            pointsArrayList.Add(b);
                        }
                        _drawHandlers.ShapesList[i].PointsArray = new List<Point>(pointsArrayList).ToArray();
                    }
                    copiedShape.StartOrigin = a;
                    copiedShapes.Add(copiedShape);
                }
            }
            _drawHandlers.ShapesList.AddRange(copiedShapes);
            _undoLists.Add(copiedShapes);
            _operationName = "Копирование";
        }

        public void Undo()
        {
            var shapes = new List<IShape>(_undoLists[_undoLists.Count - 1]);
            do
            {
                if (shapes.Count > 0)
                {
                    _drawHandlers.ShapesList.Remove(shapes[shapes.Count - 1]);
                    shapes.Remove(shapes[shapes.Count - 1]);
                }
            } while (shapes.Count > 0);
            _redoLists.Add(_undoLists[_undoLists.Count - 1]);
            _undoLists.Remove(_undoLists[_undoLists.Count - 1]);
        }

        public void Redo()
        {
            if (_redoLists.Count > 0)
            {
                _drawHandlers.ShapesList.AddRange(_redoLists[_redoLists.Count - 1]);
            }
            _undoLists.Add(_redoLists[_redoLists.Count - 1]);
            _redoLists.Remove(_redoLists[_redoLists.Count - 1]);
        }


        public string Operation()
        {
            return _operationName;
        }
    }
}