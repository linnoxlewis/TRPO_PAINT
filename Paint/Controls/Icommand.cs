using System.Drawing;
using System.Windows.Forms;
using PaintOVV.Shapes;

namespace PaintOVV.Controls
{
   
    public interface ICommand
    {
        void Execute(Graphics g, MouseEventArgs e, IShape tempShape);

        void Undo();

        void Redo();

        string Operation();
    }
}
