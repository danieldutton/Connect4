using C4.Model;

namespace C4.Tests_Unit
{
    public static class Mother
    {
        private const int XDimension = 7;

        private const int YDimension = 6;


        public static Tile[,] GetGridOneTokenOffBeingFull()
        {
            var grid = new Tile[XDimension, YDimension];

            for (int i = 0; i < XDimension; i++)
            {
                for (int j = 0; j < YDimension; j++)
                {
                    grid[i, j] = new Tile {GameToken = GameToken.Red};
                } 
            }
            grid[6, 0].GameToken = GameToken.Undefined;

            return grid;
        }

        public static Tile[,] GetFullGridWhereTheGameHasDrawn()
        {
            var grid = new Tile[XDimension, YDimension];

            for (int i = 0; i < XDimension; i++)
            {
                for (int j = 0; j < YDimension; j++)
                {
                    if (j % 2 == 0)
                        grid[i, j] = new Tile {GameToken = GameToken.Red};
                    else
                        grid[i, j] = new Tile {GameToken = GameToken.Yellow};
                }
            }

            grid[6, 0].GameToken = GameToken.Undefined;

            return grid;
        }

        public static Tile[,] GetAGridFullOfRedTokens()
        {
            var grid = new Tile[XDimension, YDimension];

            for (int i = 0; i < XDimension; i++)
            {
                for (int j = 0; j < YDimension; j++)
                {
                    grid[i, j] = new Tile {GameToken = GameToken.Red};
                }
            }
            return grid;
        }

        public static Tile[,] GetAGridFullOfYellowTokens()
        {
            var grid = new Tile[XDimension, YDimension];

            for (int i = 0; i < XDimension; i++)
            {
                for (int j = 0; j < YDimension; j++)
                {
                    grid[i, j] = new Tile { GameToken = GameToken.Yellow };
                }
            }
            return grid;
        }
    }
}
