using C4.GridBuilder.Model;
using C4.WinAnalyser.Interfaces;

namespace C4.WinAnalyser.Strategies
{
    public class Vertical : IFourInARow
    {
        public bool HasFourInARow(Tile[,] grid, GameToken tokenToCheckFor)
        {
            for (int i = 0; i < grid.GetLength(1); ++i)
            {
                int counter = 0;
                
                for (int j = 0; j < grid.GetLength(0); ++j)
                {
                    if (grid[j, i].GameToken == tokenToCheckFor)
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
