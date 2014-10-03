using C4.GridBuilder.Model;
using C4.WinAnalyser.Interfaces;

namespace C4.WinAnalyser
{
    public class Horizontal : IFourInARow
    {
        public bool HasFourInARow(Tile[,] grid, GameToken tokenToCheckFor)
        {
            int counter = 0;
            
            for (int i = 0; i < grid.GetLength(0); ++i)
            {
                for (int j = 0; j < grid.GetLength(1); ++j)
                {
                    if (grid[i, j].GameToken == tokenToCheckFor)
                        counter++;
                    else
                        counter = 0;

                    if (counter == 4)
                        return true;
                }
            }
            return false;
        }
    }
}
