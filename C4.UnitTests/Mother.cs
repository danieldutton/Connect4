using C4.Model;

namespace C4.Tests_Unit
{
    public static class Mother
    {
        public static Tile[,] GetGridOneTokenOffBeingFull()
        {
            var grid = new Tile[7, 6];

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    grid[i, j] = new Tile {GameToken = GameToken.Red};
                } 
            }

            grid[6, 0].GameToken = GameToken.Undefined;

            return grid;
        }

        public static Tile[,] GetFullGridRedToken()
        {
            var grid = new Tile[7, 6];

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    grid[i, j] = new Tile {GameToken = GameToken.Red};
                }
            }
            return grid;
        }
    }
}
