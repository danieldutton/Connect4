using C4.GridBuilder;
using C4.GridBuilder.Interfaces;
using C4.Logic;
using C4.Model;
using System;
using System.Windows.Forms;
using C4.Utilities;
using C4.Utilities.Interfaces;

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
            INameFormatter nameFormatter = new NameFormatter();
            var gameOptions = new ConfirmPlayers(nameFormatter);
            //referee should really be injected here
            var referee = new Referee(gameBoard);
            var gameOver = new GameOver();
            
            gameOver.RegisterForRefereeGameWonEvent(referee);
            gameOver.RegisterForRefereeGameDrawnEvent(referee);
            
            var game = new Game(gameBoard);
            game.RegisterForConfirmPlayers_PlayersConfirmedEvent(gameOptions);
            
            gameOptions.ShowDialog();

            Application.Run(game);
        }
    }
}
