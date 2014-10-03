using C4.GridBuilder;
using C4.GridBuilder.Interfaces;
using C4.GridBuilder.Model;
using System;
using System.Windows.Forms;

namespace C4.Presentation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IGridBuilder<Tile> gridBuilder = new GridBuilder<Tile>();

            var gameSetup = new GameSetup(gridBuilder);

            Application.Run(gameSetup);
        }
    }
}
