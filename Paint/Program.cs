﻿using System;
using System.Windows.Forms;
using PaintOVV.GUI;

namespace PaintOVV
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
