using System;
using System.Windows.Forms;
using MNC.Derivatives;
using MNC.Roots;
using MNC.Integrals;
using MNC.LinearSystems;
using MNC.Interpolations;

namespace MNC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInterpolations());
        }
    }
}
