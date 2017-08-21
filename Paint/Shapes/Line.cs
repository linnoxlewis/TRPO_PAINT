using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintOVV.Shapes
{
   
    [Serializable]
    internal class Line : IShape
    {
        public Point StartOrigin { get; set; }
        public Point EndOrigin { get; set; }
        public Point[] PointsArray { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int ShapeSize { get; set; }
        public Color ChosenColor { get; set; }
        public Color FillColor { get; set; }
        public bool IsSelected { get; set; }
        public string ShapeName { get; set; }
        public DashStyle PenStyle { get; set; }

       
        public Line(Point startOrigin, Point endOrigin, Color chosenColor, int shapeSize, DashStyle penStyle, 
            bool isSelected, int width, int height)
        {
            StartOrigin = startOrigin;
            EndOrigin = endOrigin;
            ChosenColor = chosenColor;
            ShapeSize = shapeSize;
            PenStyle = penStyle;
            IsSelected = isSelected;
            Width = width;
            Height = height;
            ShapeName = "Line";
        }

    
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(ChosenColor, ShapeSize) {DashStyle = PenStyle};
            g.DrawLine(pen, StartOrigin, EndOrigin);
        }

       
        public bool ContainsPoint(Point p)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddLine(StartOrigin, EndOrigin);
            bool pointWithinLine = myPath.IsOutlineVisible(p, new Pen(ChosenColor, ShapeSize));

            if (pointWithinLine)
            {
                return true;
            }
            return false;
        }

    
        public bool ContainsSelectedFigure(Point startPoint, Point endPoint)
        {
            var rect = new System.Drawing.Rectangle();
            if ((endPoint.Y > startPoint.Y) && (endPoint.X > startPoint.X))
            {
                rect.X = startPoint.X;
                rect.Y = startPoint.Y;
                rect.Height = endPoint.Y - startPoint.Y;
                rect.Width = endPoint.X - startPoint.X;
            }
            else if ((endPoint.Y < startPoint.Y) && (endPoint.X < startPoint.X))
            {
                rect.X = endPoint.X;
                rect.Y = endPoint.Y;
                rect.Height = startPoint.Y - endPoint.Y;
                rect.Width = startPoint.X - endPoint.X;
            }
            else if ((endPoint.Y > startPoint.Y) && (endPoint.X < startPoint.X))
            {
                rect.X = endPoint.X;
                rect.Y = startPoint.Y;
                rect.Height = endPoint.Y - startPoint.Y;
                rect.Width = startPoint.X - endPoint.X;
            }
            else if ((endPoint.Y < startPoint.Y) && (endPoint.X > startPoint.X))
            {
                rect.X = startPoint.X;
                rect.Y = endPoint.Y;
                rect.Height = startPoint.Y - endPoint.Y;
                rect.Width = endPoint.X - startPoint.X;
            }
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddRectangle(rect);

            bool pointWithinEllipse = myPath.IsVisible(StartOrigin.X, StartOrigin.Y);
            if (pointWithinEllipse)
            {
                IsSelected = true;
                return true;
            }

            return false;
        }

        
        public void SetShapeIsSelected(bool isSelected)
        {
            IsSelected = isSelected;
        }

   
        public bool GetShapeIsSelected()
        {
            return IsSelected;
        }

       
        public IShape Clone()
        {
            return new Line(StartOrigin, EndOrigin, ChosenColor, ShapeSize, PenStyle, IsSelected, Width, Height);
        }
    }
}
