using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintOVV.Shapes
{
   
    public interface IShape
    {
        Point StartOrigin { get; set; }
        Point EndOrigin { get; set; }
        Point[] PointsArray { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        int ShapeSize { get; set; }
        Color ChosenColor { get; set; }
        Color FillColor { get; set; }
        bool IsSelected { get; set; }
        string ShapeName { get; set; }
        DashStyle PenStyle { get; set; }

        void Draw(Graphics g);
        IShape Clone();
        bool ContainsPoint(Point p);
        bool ContainsSelectedFigure(Point startPoint, Point endPoint);
        void SetShapeIsSelected(bool isSelected);
        bool GetShapeIsSelected();
    }
}
