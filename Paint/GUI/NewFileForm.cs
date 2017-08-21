using System;
using System.Windows.Forms;

namespace PaintOVV.GUI
{
    /// <summary>
    /// Class to create a new form of drawing
    /// </summary>
    public partial class NewFileForm : Form
    {
        private bool inputerror = false;
        private bool notdigit = false;
        private bool emptyfield = false;

        /// <summary>
        /// class constructor
        /// </summary>
        public NewFileForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method of creating a new form of drawing on the data entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            if (usersSize.Checked)
            {
                if (notdigit || emptyfield || inputerror) MessageBox.Show(@"Введены неверные данные!");
                else
                {
                    MainForm.PanelWidth = Convert.ToInt32(numericUpDown1.Text);
                    MainForm.PanelHeight = Convert.ToInt32(numericUpDown2.Text);
                    Close();
                }
            }
            else
            {
                if (defaultSize1.Checked)
                {
                    MainForm.PanelWidth = 320;
                    MainForm.PanelHeight = 240;
                }
                else if (defaultSize2.Checked)
                {
                    MainForm.PanelWidth = 640;
                    MainForm.PanelHeight = 480;
                }
                else if (defaultSize3.Checked)
                {
                    MainForm.PanelWidth = 800;
                    MainForm.PanelHeight = 600;
                }
                else if (defaultSize4.Checked)
                {
                    MainForm.PanelWidth = 1024;
                    MainForm.PanelHeight = 768;
                }
                Close();
            }
        }
    }
}
