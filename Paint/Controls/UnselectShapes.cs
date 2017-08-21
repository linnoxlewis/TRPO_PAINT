using PaintOVV.GUI;

namespace PaintOVV.Controls
{
    /// <summary>
    /// Class undo selection figures
    /// </summary>
    public class UnselectShapes
    {
        private readonly DrawHandlers _drawHandlers;

        
        public UnselectShapes(DrawHandlers drawHandlers)
        {
            _drawHandlers = drawHandlers;
        }

       
        public void UnselectAllShapes()
        {
            for (int i = _drawHandlers.ShapesList.Count - 1; i >= 0; i--)
            {
                if (_drawHandlers.ShapesList[i] == null) continue;
                _drawHandlers.ShapesList[i].SetShapeIsSelected(false);
            }
        }
    }
}