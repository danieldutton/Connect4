using C4.Model;

namespace C4._UnitTests
{
    public static class Mother
    {
        private const int XDimension = 7;

        private const int YDimension = 6;


        public static Tile[,] GetGridOneTokenFromFull()
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

        public static Tile[,] GetGridAllRedTokens()
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

        public static Tile[,] GetGridAllYellowTokens()
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

        public static Tile[,] GetGridGameDrawn()
        {
            var grid = new Tile[XDimension,YDimension];

            for (int i = 0; i < XDimension; i++)
            {
                for (int j = 0; j < YDimension; j++)
                {
                    grid[i, j] = new Tile();
                }
            }

            //row 0 
            grid[0, 0].GameToken = GameToken.Yellow;    grid[0, 1].GameToken = GameToken.Red;
            grid[0, 2].GameToken = GameToken.Yellow;    grid[0, 3].GameToken = GameToken.Red;
            grid[0, 4].GameToken = GameToken.Red;       grid[0, 5].GameToken = GameToken.Yellow;      
            
            //row 1
            grid[1, 0].GameToken = GameToken.Yellow;    grid[1, 1].GameToken = GameToken.Red;    
            grid[1, 2].GameToken = GameToken.Yellow;    grid[1, 3].GameToken = GameToken.Red;    
            grid[1, 4].GameToken = GameToken.Yellow;    grid[1, 5].GameToken = GameToken.Red;
            

            //row 2
            grid[2, 0].GameToken = GameToken.Red;       grid[2, 1].GameToken = GameToken.Yellow;
            grid[2, 2].GameToken = GameToken.Red;       grid[2, 3].GameToken = GameToken.Yellow;
            grid[2, 4].GameToken = GameToken.Red;       grid[2, 5].GameToken = GameToken.Yellow;
                
            
            //row 3
            grid[3, 0].GameToken = GameToken.Yellow;    grid[3, 1].GameToken = GameToken.Yellow;    
            grid[3, 2].GameToken = GameToken.Red;       grid[3, 3].GameToken = GameToken.Yellow;    
            grid[3, 4].GameToken = GameToken.Red;       grid[3, 5].GameToken = GameToken.Yellow;  
            

            //row 4
            grid[4, 0].GameToken = GameToken.Red;       grid[4, 1].GameToken = GameToken.Yellow;
            grid[4, 2].GameToken = GameToken.Red;       grid[4, 3].GameToken = GameToken.Yellow;
            grid[4, 4].GameToken = GameToken.Red;       grid[4, 5].GameToken = GameToken.Yellow;
                
            
            //row 5
            grid[5, 0].GameToken = GameToken.Yellow;    grid[5, 1].GameToken = GameToken.Red;    
            grid[5, 2].GameToken = GameToken.Yellow;    grid[5, 3].GameToken = GameToken.Red;    
            grid[5, 4].GameToken = GameToken.Yellow;    grid[5, 5].GameToken = GameToken.Red;    
            
            //row 6
            grid[6, 0].GameToken = GameToken.Red;       grid[6, 1].GameToken = GameToken.Yellow;
            grid[6, 2].GameToken = GameToken.Red;       grid[6, 3].GameToken = GameToken.Red;
            grid[6, 4].GameToken = GameToken.Red;       grid[6, 5].GameToken = GameToken.Yellow;

            return grid;
        }
    }
}
