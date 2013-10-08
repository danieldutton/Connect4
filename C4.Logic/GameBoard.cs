using C4.Logic.EventArg;
using C4.Model;
using System;

namespace C4.Logic
{
    public class GameBoard
    {
        public event EventHandler<ColumnFullEventArgs> ColumnFull;

        public event EventHandler<TokenPlacedEventArgs> GameTokenPlaced;   //referee subscribe to - to check the winner

        public static GameBoard GameBoardInstance { get; set; }

        public Tile[,] Grid { get; set; }


        private GameBoard(Tile[,] grid)
        {
            Grid = grid;
        }

        public static GameBoard GetGameInstance(Tile[,] grid)
        {
            if (grid == null) throw new ArgumentNullException("grid");

            return GameBoardInstance ?? (GameBoardInstance = new GameBoard(grid));
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
                    OnGameTokenPlaced(new TokenPlacedEventArgs(Grid));
                    break;
                }
                OnColumnFull(new ColumnFullEventArgs(xDim));
            }
        }

        private bool ColumnIsFull(int xDim)
        {
            return Grid[xDim, 0].GameToken != GameToken.Undefined;
        }

        protected virtual void OnColumnFull(ColumnFullEventArgs e)
        {
            EventHandler<ColumnFullEventArgs> handler = ColumnFull;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnGameTokenPlaced(TokenPlacedEventArgs e)
        {
            EventHandler<TokenPlacedEventArgs> handler = GameTokenPlaced;
            if (handler != null) handler(this, e);
        }
    }
}
