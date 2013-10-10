using C4.GridBuilder;
using C4.GridBuilder.Interfaces;
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
            var gameOptions = new GameOptions();
            //referee should really be injected here
            var referee = new Referee(gameBoard);
            var game = new Game(gameBoard);
            game.RegisterForOptionsNotifiction(gameOptions);

            
            gameOptions.ShowDialog();

            Application.Run(game);
        }
    }
}
