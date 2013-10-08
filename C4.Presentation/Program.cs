using System;
using System.Windows.Forms;
using C4.Logic;
using C4.Model;

namespace C4.Presentation
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

            var gridGenerator = new GridGenerator<Tile>();


            Application.Run(new Form1(gridGenerator));
        }
    }
}
