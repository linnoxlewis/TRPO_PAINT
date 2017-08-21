using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PaintOVV.GUI;
using PaintOVV.Shapes;

namespace PaintOVV.Controls
{
    /// <summary>
    /// Class updates the parameters of the figure
    /// </summary>
    public class UpdateShape : ICommand
    {

        #region Properties

        private readonly DrawHandlers _drawHandlers;
        private readonly List<List<IShape>> _currentLists = new List<List<IShape>>();
        private readonly List<List<IShape>> _previousLists = new List<List<IShape>>();
        private string _operationName;
        private readonly NumericUpDown _lineSize;

        #endregion

        /// <summary>
        /// Create the instance of class <see cref="UpdateShape"/>
        /// </summary>
        /// <param name="drawHandlers"></param>
        /// <param name="lineSize"></param>
        public UpdateShape(DrawHandlers drawHandlers, NumericUpDown lineSize)
        {
            _drawHandlers = drawHandlers;
            _lineSize = lineSize;
        }

        /// <summary>
        /// Method updates the parameters of the figure
        /// </summary>
        /// <param name="g"></param>
        /// <param name="e"></param>
        /// <param name="tempShape"></param>
        public void Execute(Graphics g, MouseEventArgs e, IShape tempShape)
        {
            var undoShapes = new List<IShape>();
            foreach (IShape shape in _drawHandlers.ShapesList)
            {
                var shapeA = shape.Clone();
                undoShapes.Add(shapeA);
                if (_drawHandlers.IndexOfSelectedShape != null && shape.GetShapeIsSelected() && _drawHandlers.IndexOfSelectedShape != null)
                {
                    _drawHandlers.LineStyle();
                    shape.ChosenColor = _drawHandlers.ChosenColor;
                    shape.FillColor = _drawHandlers.FillColor;
                    shape.ShapeSize = (int)_lineSize.Value;
                    shape.PenStyle = _drawHandlers.PenStyle;
                }
            }
            _previousLists.Add(undoShapes);
            _operationName = "Редактирование";
        }

        /// <summary>
        /// Undo new parameters
        /// </summary>
        public void Undo()
        {
            if (_previousLists.Count > 0)
            {
                _currentLists.Add(_drawHandlers.ShapesList);
                _drawHandlers.ShapesList = new List<IShape>(_previousLists[_previousLists.Count - 1]);
                _previousLists.Remove(_previousLists[_previousLists.Count - 1]);
            }
        }

        /// <summary>
        /// Redo new parameters
        /// </summary>
        public void Redo()
        {
            if (_currentLists.Count > 0)
            {
                _previousLists.Add(_drawHandlers.ShapesList);
                _drawHandlers.ShapesList = new List<IShape>(_currentLists[_currentLists.Count - 1]);
                _currentLists.Remove(_currentLists[_currentLists.Count - 1]);
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
    }
}