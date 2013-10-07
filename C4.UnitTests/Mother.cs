using C4.Model;

namespace C4.UnitTests
{
    public static class Mother
    {
        public static Tile[,] GetEmptyGrid()
        {
            return new Tile[7,6];
        }

        public static Tile[,] GetGridHalfFull()
        {
            var grid = new Tile[7, 6];

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    grid[i, j].GameToken = GameToken.Red;
                }
            }

            return grid;
        }

        public static Tile[,] GetGridOneTokenOffBeingFull()
        {
            var grid = new Tile[7, 6];

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    grid[i, j] = new Tile();
                    grid[i, j].GameToken = GameToken.Red;
                } 
            }

            grid[6, 0].GameToken = GameToken.Undefined;

            return grid;
        }

        public static Tile[,] GetFullGrid()
        {
            var grid = new Tile[7, 6];

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    grid[i, j].GameToken = GameToken.Red;
                }
            }

            return grid;
        }
    }
}
