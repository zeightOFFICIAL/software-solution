using System;
using System.Windows.Forms;

namespace software_solution
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.d
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
