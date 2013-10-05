using C4.Logic.EventArg;
using C4.Logic.Interfaces;
using System;

namespace C4.Logic
{
    public class GameGrid<T>
    {
        public event EventHandler<TokenEventArg> TokenAdded;
       
        public event EventHandler<EventArgs> GridFull;

        public event EventHandler<EventArgs> GridEmptied;

        private readonly IGridGenerator<T> _iGridGenerator;

        public T[,] Grid { get; set; }


        public GameGrid()
        {
            InitGrid();
        }


        public GameGrid(IGridGenerator<T> gridGenerator)
        {
            _iGridGenerator = gridGenerator;
            InitGrid();
        }

        public void Makemove(int xDim)
        {
        
        }

        public void InitGrid()
        {
            Grid = _iGridGenerator.GetGrid(7, 6);
        }

        #region Event Invocators

        protected virtual void OnTokenAdded(TokenEventArg e)
        {
            EventHandler<TokenEventArg> handler = TokenAdded;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnGridFull()
        {
            EventHandler<EventArgs> handler = GridFull;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnGridEmptied()
        {
            EventHandler<EventArgs> handler = GridEmptied;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        #endregion
    }
}
