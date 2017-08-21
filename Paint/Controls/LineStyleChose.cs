using System.Drawing.Drawing2D;
using PaintMV.GUI;

namespace PaintMV.Controls
{
    /// <summary>
    /// Class selection line style
    /// </summary>
    public class LineStyleChose
    {
        private readonly MainForm _mainForm;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="mainForm"></param>
        public LineStyleChose(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        /// <summary>
        /// Line style method
        /// </summary>
        public void LineStyle()
        {
            if (_mainForm.radioSolid.Checked)
            {
                _mainForm.PenStyle = DashStyle.Solid;
            }
            else if (_mainForm.radioDash.Checked)
            {
                _mainForm.PenStyle = DashStyle.Dash;
            }
            else if (_mainForm.radioDot.Checked)
            {
                _mainForm.PenStyle = DashStyle.Dot;
            }
        }
    }
}