using C4.GridBuilder;
using C4.GridBuilder.Interfaces;
using C4.Logic;
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
            Tile[,] grid = gridGenerator.GetGrid(6, 7);
            
            GameBoard gameBoard = GameBoard.GetGameInstance();
            gameBoard.Grid = grid;
            var gameOptions = new GameOptions();
            //referee should really be injected here
            var referee = new Referee(gameBoard);
            var gameOver = new GameOver();
            
            gameOver.RegisterForRefereesGameWonEvent(referee);
            gameOver.RegisterForRefereesGameDrawnEvent(referee);
            
            var game = new Game(gameBoard);
            game.RegisterForPlayersConfirmedEvent(gameOptions);
            
            gameOptions.ShowDialog();

            Application.Run(game);
        }
    }
}
