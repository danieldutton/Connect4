using C4.Logic.EventArg;
using C4.Logic.Interfaces;
using C4.Model;
using System;
using System.Linq;

namespace C4.Logic
{
    public class GameBoard
    {
        #region Events

        public event EventHandler<EventArgs> GridFull;
       
        public event EventHandler<ColumnFullEventArgs> ColumnFull;

        public event EventHandler<EventArgs> GameTokenPlaced;

        #endregion

        #region Properties

        public static GameBoard GameBoardInstance { get; set; }

        private static IGridGenerator<Tile> _gridGenerator;

        public Tile[,] Grid { get; set; }

        private IReferee _referee;

        #endregion

        #region Constructor(s)

        private GameBoard()
        {
            InitialiseGameBoard();
        }

        #endregion

        #region Method(s)

        public void InitialiseGameBoard()
        {
            Grid = _gridGenerator.GetGrid(7, 6);
        }

        public static GameBoard GetGameInstance(IGridGenerator<Tile> gridGenerator, IReferee gameReferee)
        {
            if (gridGenerator == null) throw new ArgumentNullException();
                _gridGenerator = gridGenerator;
            if (gameReferee == null) throw new ArgumentNullException();

            return GameBoardInstance ?? (GameBoardInstance = new GameBoard());
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

            if (GridIsFull())
            {
                OnGridFull();
            }
        }

        private bool ColumnIsFull(int xDim)
        {
            return Grid[xDim, 0].GameToken != GameToken.Undefined;
        }

        private bool GridIsFull()
        {
            var flattenedGrid = Grid.Cast<Tile>().ToArray();

            return flattenedGrid.All(x => x.GameToken != GameToken.Undefined);
        }

        #endregion

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
