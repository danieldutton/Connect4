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

        public Tile[,] GameGrid { get; set; }


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
            Tile[] flattenedGrid = GameGrid.Cast<Tile>().ToArray();

            return flattenedGrid.All(x => x.GameToken != GameToken.Undefined);
        }

        public GameToken CheckRowsForWin()
        {
            int counter = 0;

            for (int i = 0; i < GameGrid.GetLength(0); i++)
            {
                for (int j = 0; j < GameGrid.GetLength(1); j++)
                {
                    if (GameGrid[i, j].GameToken == GameToken.Red)
                    {
                        counter++;
                        if (counter == 4) return GameToken.Red;
                    } 
                    else if (GameGrid[i, j].GameToken == GameToken.Yellow && counter <= 0)
                    {
                        counter--;
                        if (counter == -4) return GameToken.Yellow;
                    }
                }
                //set winning player in here to property
            }

            throw new NotImplementedException();
        }

        public GameToken CheckColumnsForWin()
        {
            throw new NotImplementedException();
        }

        public GameToken CheckDiagonalRowsForWin()
        {
            throw new NotImplementedException();
        }

        #region Event Invocators

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
            EventHandler<EventArgs> handler = GameDrawn;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        #endregion
    }
}
