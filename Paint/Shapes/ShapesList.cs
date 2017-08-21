using System;
using System.Collections.Generic;

namespace PaintMV.Shapes
{
    /// <summary>
    /// Class with a list of figures
    /// </summary>
    [Serializable]
    public class ShapesList
    {
        public List<Shape> AllShapes = new List<Shape>();
    }
}
