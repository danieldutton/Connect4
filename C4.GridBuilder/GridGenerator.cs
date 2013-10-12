using System;
using C4.GridBuilder.Interfaces;

namespace C4.GridBuilder
{
    public class GridGenerator<T> : IGridGenerator<T> 
        where T: IPlottable, new()
    {
        public T[,] GetGrid(int xDim, int yDim)
        {
            if(xDim < 0 || yDim < 0) throw new ArgumentOutOfRangeException();

            var grid = new T[xDim, yDim];

            for (int i = 0; i < xDim; i++)
            {
                for (int j = 0; j < yDim; j++)
                {
                    grid[i, j] = new T{XPosition = i, YPosition = j};
                }
            }
            return grid;
        }
    } 
}
