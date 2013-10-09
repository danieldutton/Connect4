using System.Windows.Forms;
using C4.Logic.EventArg;
using C4.Logic.Interfaces;
using C4.Model;
using System;
using System.Linq;

namespace C4.Logic
{
    public class Referee : IReferee
    {
        public event EventHandler<WinnerDetailsEventArgs> GameWon;

        public event EventHandler<EventArgs> GameNotWon;

        public event EventHandler<EventArgs> GameDrawn;

        public GameBoard GameBoard { get; set; }


        public Referee(GameBoard gameBoard)
        {
            GameBoard = gameBoard;
            SubScribeToGameBoardEvents();
        }

        private void SubScribeToGameBoardEvents()
        {
            GameBoard.GameTokenPlaced +=GameBoard_GameTokenPlaced;
        }

        private void GameBoard_GameTokenPlaced(object sender, TokenPlacedEventArgs e)
        {
            GameBoard.Grid = e.CurrentGrid;
            CheckForWinner();
        }

        public void CheckForWinner()
        {
            if (CheckForDraw()) { OnGameDrawn(); return; }

            GameToken gameTokenRow = CheckRowsForWin();
            if (gameTokenRow != GameToken.Undefined) { OnGameWon(new WinnerDetailsEventArgs(gameTokenRow)); return; }

            GameToken gameTokenColumn = CheckColumnsForWin();
            if (gameTokenColumn != GameToken.Undefined) { OnGameWon(new WinnerDetailsEventArgs(gameTokenColumn)); return; }

            GameToken gameTokenDiagonal = CheckDiagonalRowsForWin();
            if (gameTokenDiagonal != GameToken.Undefined) { OnGameWon(new WinnerDetailsEventArgs(gameTokenDiagonal)); return; }
            
            OnGameNotWon();
        }

        public bool CheckForDraw()
        {
            Tile[] flattenedGrid = GameBoard.Grid.Cast<Tile>().ToArray();

            return flattenedGrid.All(x => x.GameToken != GameToken.Undefined);
        }

        public GameToken CheckRowsForWin()
        {
            int counter = 0;

            for (int i = 0; i < GameBoard.Grid.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.Grid.GetLength(1); j++)
                {
                    if (GameBoard.Grid[i, j].GameToken == GameToken.Red)
                    {
                        counter++;
                        if (counter == 4) return GameToken.Red;
                    }
                    else if (GameBoard.Grid[i, j].GameToken == GameToken.Yellow && counter <= 0)
                    {
                        counter--;
                        if (counter == -4) return GameToken.Yellow;
                    }
                }
                //set winning player in here to property
            }

            return GameToken.Red;
        }

        public GameToken CheckColumnsForWin()
        {
            return GameToken.Red;
        }

        public GameToken CheckDiagonalRowsForWin()
        {
            return GameToken.Red;
        }

        protected virtual void OnGameWon(WinnerDetailsEventArgs e)
        {
            EventHandler<WinnerDetailsEventArgs> handler = GameWon;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnGameNotWon()
        {
            EventHandler<EventArgs> handler = GameNotWon;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnGameDrawn()
        {
            MessageBox.Show("Game is drawn");
            EventHandler<EventArgs> handler = GameDrawn;
            if (handler != null) handler(this, EventArgs.Empty);
        }

    }
}
