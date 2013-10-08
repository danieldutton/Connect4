using C4.Logic.EventArg;
using C4.Logic.Interfaces;
using C4.Model;
using System;

namespace C4.Logic
{
    public class Referee : IReferee
    {
        public event EventHandler<WinnerDetailsEventArgs> DeclareWinner;

        public Tile[,] GameGrid { get; set; }

        public Player PlayerRed { get; set; }

        public Player PlayerYellow{ get;set; }


        public void Foo(Tile[,] gameGrid)
        {
            GameGrid = gameGrid;
        }

        public bool CheckRowsForWin()
        {
            int counter = 0;

            for (int i = 0; i < GameGrid.GetLength(0); i++)
            {
                for (int j = 0; j < GameGrid.GetLength(1); j++)
                {
                    if (GameGrid[i, j].GameToken == GameToken.Red)
                    {
                        counter++;
                        if (counter == 4) return true;
                    } 
                    else if (GameGrid[i, j].GameToken == GameToken.Yellow && counter <= 0)
                    {
                        counter--;
                        if (counter == -4) return true;
                    }
                }
                //set winning player in here to property
            }

            return true;
        }

        public bool CheckColumnsForWin()
        {
            throw new NotImplementedException();
        }

        public bool CheckDiagonalRowsForWin()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnDeclareWinner(WinnerDetailsEventArgs e)
        {
            EventHandler<WinnerDetailsEventArgs> handler = DeclareWinner;
            if (handler != null) handler(this, e);
        }
  }
}
