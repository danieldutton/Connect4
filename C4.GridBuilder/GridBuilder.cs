using C4.GridBuilder.Interfaces;
using System;

namespace C4.GridBuilder
{
    public class GridBuilder<T> : IGridBuilder<T> 
        where T: IPlottable, new()
    {
        public T[,] GetGrid(int rows, int columns)
        {
            if(rows < 0 || columns < 0) throw new ArgumentOutOfRangeException();

            var grid = new T[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    grid[i, j] = new T {XPosition = i, YPosition = j};
                }
            }
            return grid;
        }
    } 
}
