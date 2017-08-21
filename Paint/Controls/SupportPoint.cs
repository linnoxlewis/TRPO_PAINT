using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PaintOVV.Enumerations;
using PaintOVV.GUI;
using PaintOVV.Shapes;
using Rectangle = System.Drawing.Rectangle;

namespace PaintOVV.Controls
{
   
    public class SupportPoints
    {

        #region Properties

        private readonly List<Rectangle> _rectangleList = new List<Rectangle>();
        private readonly DrawHandlers _drawHandlers;
        private const int SizeNodeRect = 10;
        public bool PolygonSelection { get; set; }

        #endregion

       
        public SupportPoints(DrawHandlers drawHandlers)
        {
            _drawHandlers = drawHandlers;
        }

        
        public Rectangle GetRect(int value, IShape shape)
        {
            int xValue = shape.StartOrigin.X;
            int yValue = shape.StartOrigin.Y;

            switch (value)
            {
                case 0:
                    return new Rectangle(xValue - 3 - SizeNodeRect / 2, yValue - 3 - SizeNodeRect / 2, SizeNodeRect, SizeNodeRect);

                case 1:
                    return new Rectangle(xValue - 4 - SizeNodeRect / 2, yValue + shape.Height / 2 - SizeNodeRect / 2, SizeNodeRect, SizeNodeRect);

                case 2:
                    return new Rectangle(xValue - 3 - SizeNodeRect / 2, yValue + 3 + shape.Height - SizeNodeRect / 2, SizeNodeRect, SizeNodeRect);

                case 3:
                    return new Rectangle(xValue + shape.Width / 2 - SizeNodeRect / 2, yValue + 3 + shape.Height - SizeNodeRect / 2, SizeNodeRect, SizeNodeRect);

                case 4:
                    return new Rectangle(xValue + 3 + shape.Width - SizeNodeRect / 2, yValue - 3 - SizeNodeRect / 2, SizeNodeRect, SizeNodeRect);

                case 5:
                    return new Rectangle(xValue + 3 + shape.Width - SizeNodeRect / 2, yValue + 3 + shape.Height - SizeNodeRect / 2, SizeNodeRect, SizeNodeRect);

                case 6:
                    return new Rectangle(xValue + 3 + shape.Width - SizeNodeRect / 2, yValue + shape.Height / 2 - SizeNodeRect / 2, SizeNodeRect, SizeNodeRect);

                case 7:
                    return new Rectangle(xValue + shape.Width / 2 - SizeNodeRect / 2, yValue - 4 - SizeNodeRect / 2, SizeNodeRect, SizeNodeRect);

                case 8:
                    return new Rectangle(shape.EndOrigin.X - SizeNodeRect / 2, shape.EndOrigin.Y - SizeNodeRect / 2, SizeNodeRect, SizeNodeRect);

                case 9:
                    return new Rectangle(shape.StartOrigin.X - SizeNodeRect / 2, shape.StartOrigin.Y - SizeNodeRect / 2, SizeNodeRect, SizeNodeRect);

                default:
                    return new Rectangle();
            }
        }

        
        public Positions GetNodeSelectable(Point p)
        {
            if (PolygonSelection)
            {
                PolygonPoints();
                foreach (var rect in _rectangleList.Where(rect => rect.Contains(p)))
                {
                    _drawHandlers.MoveResize.PolygonPoint = _rectangleList.IndexOf(rect);
                    return Positions.PolygonPoint;
                }
                _rectangleList.Clear();
            }
            foreach (Positions r in from Positions r in Enum.GetValues(typeof(Positions)) where GetRectangle(r).Contains(p) select r)
            {
                return r;
            }
            return Positions.None;
        }

       
        public Positions GetCursorOfPolygonPoint(Point p)
        {
            if (!PolygonSelection) return Positions.None;
            PolygonPoints();
            if (_rectangleList.Any(rect => rect.Contains(p)))
            {
                return Positions.PolygonPoint;
            }
            _rectangleList.Clear();
            return Positions.None;
        }

        public Cursor GetCursor(Positions p)
        {
            switch (p)
            {
                case Positions.LeftUp:
                    return Cursors.SizeNWSE;

                case Positions.LeftMiddle:
                    return Cursors.SizeWE;

                case Positions.LeftBottom:
                    return Cursors.SizeNESW;

                case Positions.BottomMiddle:
                    return Cursors.SizeNS;

                case Positions.RightUp:
                    return Cursors.SizeNESW;

                case Positions.RightBottom:
                    return Cursors.SizeNWSE;

                case Positions.RightMiddle:
                    return Cursors.SizeWE;

                case Positions.UpMiddle:
                    return Cursors.SizeNS;

                case Positions.RightLinePoint:
                    return Cursors.SizeNESW;

                case Positions.LeftLinePoint:
                    return Cursors.SizeNWSE;

                case Positions.PolygonPoint:
                    return Cursors.SizeNWSE;

                default:
                    return Cursors.Default;
            }
        }

      
        private Rectangle GetRectangle(Positions value)
        {
            Debug.Assert(_drawHandlers.IndexOfSelectedShape != null, "No selected figures!");
            IShape tempShape = _drawHandlers.ShapesList[_drawHandlers.IndexOfSelectedShape.Value];
            switch (value)
            {
                case Positions.LeftUp:
                    return new Rectangle(tempShape.StartOrigin.X - 5, tempShape.StartOrigin.Y - 5, SizeNodeRect, SizeNodeRect);

                case Positions.LeftMiddle:
                    return new Rectangle(tempShape.StartOrigin.X - 5, tempShape.StartOrigin.Y + tempShape.Height / 2, SizeNodeRect, SizeNodeRect);

                case Positions.LeftBottom:
                    return new Rectangle(tempShape.StartOrigin.X - 5, tempShape.StartOrigin.Y + 5 + tempShape.Height, SizeNodeRect, SizeNodeRect);

                case Positions.BottomMiddle:
                    return new Rectangle(tempShape.StartOrigin.X + tempShape.Width / 2,
                        tempShape.StartOrigin.Y + 5 + tempShape.Height, SizeNodeRect, SizeNodeRect);

                case Positions.RightUp:
                    return new Rectangle(tempShape.StartOrigin.X + 5 + tempShape.Width, tempShape.StartOrigin.Y - 5, SizeNodeRect, SizeNodeRect);

                case Positions.RightBottom:
                    return new Rectangle(tempShape.StartOrigin.X + 5 + tempShape.Width,
                        tempShape.StartOrigin.Y + 5 + tempShape.Height, SizeNodeRect, SizeNodeRect);

                case Positions.RightMiddle:
                    return new Rectangle(tempShape.StartOrigin.X + 5 + tempShape.Width,
                        tempShape.StartOrigin.Y + tempShape.Height / 2, SizeNodeRect, SizeNodeRect);

                case Positions.UpMiddle:
                    return new Rectangle(tempShape.StartOrigin.X + tempShape.Width / 2, tempShape.StartOrigin.Y - 5, SizeNodeRect, SizeNodeRect);

                case Positions.LeftLinePoint:
                    return new Rectangle(tempShape.StartOrigin.X - 5, tempShape.StartOrigin.Y - 5, SizeNodeRect,
                            SizeNodeRect);

                case Positions.RightLinePoint:
                    return new Rectangle(tempShape.EndOrigin.X - 5, tempShape.EndOrigin.Y - 5, SizeNodeRect, SizeNodeRect);

                default:
                    return new Rectangle();
            }
        }

       
        private void PolygonPoints()
        {
            if (_drawHandlers.IndexOfSelectedShape == null) return;
            var tempShape = _drawHandlers.ShapesList[_drawHandlers.IndexOfSelectedShape.Value];
            if (tempShape.PointsArray != null)
            {
                foreach (var point in tempShape.PointsArray)
                {
                    _rectangleList.Add(new Rectangle(point.X - 5, point.Y - 5, SizeNodeRect, SizeNodeRect));
                }
            }
        }
    }
}