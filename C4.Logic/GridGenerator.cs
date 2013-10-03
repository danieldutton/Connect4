using C4.Logic.Interfaces;
using C4.Model.Interfaces;

namespace C4.Logic
{
    public class GridGenerator<T> : IGridGenerator<T> 
        where T: IPlottable, new()
    {
        public T[,] GetGrid(int xDim, int yDim)
        {
            var grid = new T[xDim, yDim];

            for (int i = 0; i < xDim; i++)
            {
                for (int j = 0; j < yDim; j++)
                {
                    grid[i, j] = new T{XPos = i, YPos = j};
                }
            }
            return grid;
        }
    } 
}
