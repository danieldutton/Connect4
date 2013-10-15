using System;
using C4.GridBuilder.Interfaces;

namespace C4.GridBuilder
{
    public class GridGenerator<T> : IGridGenerator<T> 
        where T: IPlottable, new()
    {
        public T[,] GetGrid(int yDim, int xDim)
        {
            if(yDim < 0 || xDim < 0) throw new ArgumentOutOfRangeException();

            var grid = new T[yDim, xDim];

            for (int i = 0; i < yDim; i++)
            {
                for (int j = 0; j < xDim; j++)
                {
                    grid[i, j] = new T{YPosition = i, XPosition = j};
                }
            }
            return grid;
        }
    } 
}
