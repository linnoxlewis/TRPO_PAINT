using System.Drawing;
using PaintMV.GUI;
using PaintMV.Shapes;

namespace PaintMV.Controls
{
    /// <summary>
    /// Class releasing the selected line
    /// </summary>
    public class LineSelection
    {
        private readonly MainForm _mainForm;
        private int _sizeNodeRect { set; get; } = 10;

        /// <summary>
        /// class constructor
        /// </summary>
        /// <param name="mainForm"></param>
        public LineSelection(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        /// <summary>
        /// Method releasing the selected line
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="g"></param>
        public void MakeSelectionOfLine(Shape shape, Graphics g)
        {
            int xValue = shape.StartOrigin.X;
            int yValue = shape.StartOrigin.Y;

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    g.DrawEllipse(new Pen(Color.Blue), xValue - _sizeNodeRect / 2, yValue - _sizeNodeRect / 2, _sizeNodeRect, _sizeNodeRect);
                }
                else
                {
                    g.DrawEllipse(new Pen(Color.Blue), shape.EndOrigin.X - 3, shape.EndOrigin.Y - 3, _sizeNodeRect, _sizeNodeRect);
                }
            }
            Pen tempPen = new Pen(Color.Blue);
            tempPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawLine(tempPen, shape.StartOrigin.X, shape.StartOrigin.Y, shape.EndOrigin.X, shape.EndOrigin.Y);
            _mainForm.PnlGraphic.Invalidate();
        }
    }
}