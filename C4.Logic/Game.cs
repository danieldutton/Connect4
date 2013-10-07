using C4.Logic.EventArg;
using C4.Logic.Interfaces;
using C4.Model;
using System;

namespace C4.Logic
{
    public class Game
    {
        public event EventHandler<ColumnFullEventArgs> ColumnFull;

        public event EventHandler<EventArgs> GameTokenPlaced;

        public static Game GameInstance { get; set; }

        private static IGridGenerator<Tile> _gridGenerator;

        public Tile[,] Gameboard { get; private set; }


        private Game()
        {
            InitialiseGameBoard();
        }

        public void InitialiseGameBoard()
        {
            Gameboard = _gridGenerator.GetGrid(7, 6);
        }

        public static Game GetGameInstance(IGridGenerator<Tile> gridGenerator)
        {
            if (gridGenerator == null) throw new ArgumentNullException();
                _gridGenerator = gridGenerator;

            return GameInstance ?? (GameInstance = new Game());
        }

        public void TakeMove(int xDim)
        {
            if(ColumnIsFull(xDim))
            {
                OnColumnFull(new ColumnFullEventArgs(xDim));
                return;
            }

            for (int i = 5; i < Gameboard.GetLength(1);i--)
            {
                if(true){}

                if (Gameboard[xDim, i].GameToken == GameToken.Undefined)
                {
                    Gameboard[xDim, i].GameToken = GameToken.Red;
                    OnTokenPlaced();
                    break;
                }
                OnColumnFull(new ColumnFullEventArgs(xDim));
            }
        }

        private bool ColumnIsFull(int xDim)
        {
            return Gameboard[xDim, 0].GameToken != GameToken.Undefined;
        }

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
    }
}
