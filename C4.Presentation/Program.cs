using C4.Logic;
using C4.Logic.Interfaces;
using C4.Model;
using System;
using System.Windows.Forms;

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

            IGridGenerator<Tile> gridGenerator = new GridGenerator<Tile>();
            Tile[,] grid = gridGenerator.GetGrid(7, 6);
            
            GameBoard gameBoard = GameBoard.GetGameInstance(grid);

            Application.Run(new Game(gameBoard));
        }
    }
}
