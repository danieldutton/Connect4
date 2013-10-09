using C4.Logic.EventArg;
using C4.Model;
using System;
using System.Drawing;

namespace C4.Logic
{
    public class GameBoard
    {
        public event EventHandler<ColumnFullEventArgs> ColumnFull;

        public event EventHandler<TokenPlacedEventArgs> GameTokenPlaced;

        public static GameBoard GameBoardInstance { get; set; }

        public Tile[,] Grid { get; set; }

        public Player PlayerRed { get; set; }

        public Player PlayerYellow { get; set; }


        private GameBoard(Tile[,] grid)
        {
            Grid = grid;
            PlayerRed = new Player();
            PlayerYellow = new Player();
            PlayerRed.IsCurrentTurn = true;
            PlayerYellow.IsCurrentTurn = false;         
        }


        public static GameBoard GetGameInstance(Tile[,] grid)
        {
            if (grid == null) throw new ArgumentNullException("grid");

            return GameBoardInstance ?? (GameBoardInstance = new GameBoard(grid));
        }

        public void TakeMove(int xDim)
        {
            if (!ColumnIsFull(xDim))
            {
                for (int i = 5; i < Grid.GetLength(0); i--)
                {
                    if (Grid[xDim, i].GameToken == GameToken.Undefined)
                    {
                        if (PlayerRed.IsCurrentTurn)
                        {
                            Grid[xDim, i].GameToken = GameToken.Red;
                            Grid[xDim, i].BackColor = Color.Red;

                            OnGameTokenPlaced(new TokenPlacedEventArgs(Grid));

                            PlayerRed.IsCurrentTurn = false;
                            PlayerYellow.IsCurrentTurn = true;
                        }
                        else if (PlayerYellow.IsCurrentTurn)
                        {
                            Grid[xDim, i].GameToken = GameToken.Yellow;
                            Grid[xDim, i].BackColor = Color.Yellow;

                            OnGameTokenPlaced(new TokenPlacedEventArgs(Grid));

                            PlayerYellow.IsCurrentTurn = false;
                            PlayerRed.IsCurrentTurn = true;
                        }

                        break;
                    }
                }
            }
            else OnColumnFull(new ColumnFullEventArgs(xDim));
        }

        private bool ColumnIsFull(int xDim)
        {
            return Grid[xDim, 0].GameToken != GameToken.Undefined;
        }

        protected virtual void OnColumnFull(ColumnFullEventArgs e)
        {
            EventHandler<ColumnFullEventArgs> handler = ColumnFull;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnGameTokenPlaced(TokenPlacedEventArgs e)
        {
            EventHandler<TokenPlacedEventArgs> handler = GameTokenPlaced;
            if (handler != null) handler(this, e);
        }
    }
}
