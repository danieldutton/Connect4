using C4.GridBuilder.Model;
using C4.WinAnalyser.Interfaces;

namespace C4.WinAnalyser.Strategies
{
    public class Diagonal : IFourInARow
    {
        public bool HasFourInARow(Tile[,] grid, GameToken tokenToCheckFor)
        {
            for (int y = 0; y < grid.GetLength(0) - 3; y++)
            {
                for (int x = 0; x < grid.GetLength(1) - 3; x++)
                {
                    if (grid[y, x].GameToken == tokenToCheckFor
                        && grid[y + 1, x + 1].GameToken == tokenToCheckFor
                        && grid[y + 2, x + 2].GameToken == tokenToCheckFor
                        && grid[y + 3, x + 3].GameToken == tokenToCheckFor
                    )
                    {
                        return true;
                    }
                }
            }

            for (int y = 0; y < grid.GetLength(0) - 3; y++)
            {
                for (int x = 3; x < grid.GetLength(1); x++)
                {
                    if (grid[y, x].GameToken == tokenToCheckFor
                        && grid[y + 1, x - 1].GameToken == tokenToCheckFor
                        && grid[y + 2, x - 2].GameToken == tokenToCheckFor
                        && grid[y + 3, x - 3].GameToken == tokenToCheckFor
                    )
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
