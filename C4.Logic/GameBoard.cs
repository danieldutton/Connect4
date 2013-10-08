using C4.Logic.EventArg;
using C4.Logic.Interfaces;
using C4.Model;
using System;

namespace C4.Logic
{
    public class GameBoard
    {
        public event EventHandler<EventArgs> GridFull;  //declare game to be a draw
       
        public event EventHandler<ColumnFullEventArgs> ColumnFull;

        public event EventHandler<EventArgs> GameTokenPlaced;   //check with refereee for winner

        public static GameBoard GameBoardInstance { get; set; }

        public IReferee _referee;

        public Tile[,] Grid { get; set; }


        private GameBoard(IReferee gameReferee, Tile[,] grid)
        {
            _referee = gameReferee;
            Grid = grid;
        }

        public static GameBoard GetGameInstance(IReferee gameReferee, Tile[,] grid)
        {
            return GameBoardInstance ?? (GameBoardInstance = new GameBoard(gameReferee, grid));
        }

        public void TakeMove(int xDim)
        {
            if(ColumnIsFull(xDim))
            {
                OnColumnFull(new ColumnFullEventArgs(xDim));
                return;
            }

            for (int i = 5; i < Grid.GetLength(1);i--)
            {
                if(true){}

                if (Grid[xDim, i].GameToken == GameToken.Undefined)
                {
                    Grid[xDim, i].GameToken = GameToken.Red;
                    OnTokenPlaced();
                    break;
                }
                OnColumnFull(new ColumnFullEventArgs(xDim));
            }
        }

        private bool ColumnIsFull(int xDim)
        {
            return Grid[xDim, 0].GameToken != GameToken.Undefined;
        }

        #region Event Invocators

        protected virtual void OnColumnFull(ColumnFullEventArgs e)
        {
            EventHandler<ColumnFullEventArgs> handler = ColumnFull;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnTokenPlaced()
        {
            EventHandler<EventArgs> handler = GameTokenPlaced;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnGridFull()
        {
            EventHandler<EventArgs> handler = GridFull;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        #endregion
    }
}
