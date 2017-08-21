using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PaintOVV.GUI;
using PaintOVV.Shapes;

namespace PaintOVV.Controls
{
    
    public class Cut : ICommand
    {
        private readonly DrawHandlers _drawHandlers;
        private readonly List<List<IShape>> _redoLists = new List<List<IShape>>();
        private readonly List<List<IShape>> _undoLists = new List<List<IShape>>();
        private string _operationName;

        
        public Cut(DrawHandlers drawHandlers)
        {
            _drawHandlers = drawHandlers;
        }

       
        public void Execute(Graphics g, MouseEventArgs e, IShape tempShape)
        {
            var сurrentShapes = new List<IShape>(_drawHandlers.ShapesList);
            for (int i = _drawHandlers.ShapesList.Count - 1; i >= 0; i--)
            {
                if (_drawHandlers.IndexOfSelectedShape != null && _drawHandlers.ShapesList[i].GetShapeIsSelected()
                    && _drawHandlers.IndexOfSelectedShape != null)
                {
                    _drawHandlers.ShapesList[i].SetShapeIsSelected(false);
                    _drawHandlers.ShapesList.Remove(_drawHandlers.ShapesList[i]);
                }
            }
            _undoLists.Add(сurrentShapes);
            _redoLists.Add(_drawHandlers.ShapesList);
            _operationName = "Вырезание";
        }

        public void Undo()
        {
            if (_undoLists.Count > 0)
            {
                _drawHandlers.ShapesList = new List<IShape>(_undoLists[_undoLists.Count - 1]);
                _redoLists.Add(_undoLists[_undoLists.Count - 1]);
                _undoLists.Remove(_undoLists[_undoLists.Count - 1]);
            }
        }

       
        public void Redo()
        {
            _undoLists.Add(_redoLists[_redoLists.Count - 1]);
            _redoLists.Remove(_redoLists[_redoLists.Count - 1]);
            _drawHandlers.ShapesList = new List<IShape>(_redoLists[_redoLists.Count - 1]);
        }



        public string Operation()
        {
            return _operationName;
        }
    }
}