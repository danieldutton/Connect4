using C4.Logic.EventArg;
using C4.Logic.Interfaces;
using C4.Model;
using System;
using System.Drawing;

namespace C4.Logic
{
    public class GameBoard : IGameBoard
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
            PlayerRed.HasCurrentTurn = true;
            PlayerYellow.HasCurrentTurn = false;         
        }

        public static GameBoard GetGameInstance(Tile[,] grid)
        {
            if (grid == null) throw new ArgumentNullException("grid");

            return GameBoardInstance ?? (GameBoardInstance = new GameBoard(grid));
        }

        public void TakeMove(int xDim)
        {
            if (ColumnHasSpareSlot(xDim))
            {
                for (int i = 5; i < Grid.GetLength(0); i--)
                {
                    if (ChosenSlotIsFree(xDim, i))
                    {
                        if (PlayerYellow.HasCurrentTurn)
                        {
                            PushTokenInChosenSlot(xDim, i, GameToken.Yellow, Color.Yellow);
                            PlayerRed.HasCurrentTurn = true;
                            PlayerYellow.HasCurrentTurn = false;    
                        }
                        else if (PlayerRed.HasCurrentTurn)
                        {
                            PushTokenInChosenSlot(xDim, i, GameToken.Red, Color.Red);
                            PlayerRed.HasCurrentTurn = false;
                            PlayerYellow.HasCurrentTurn = true; 
                        }
                        break;
                    }
                }
            }
            else OnColumnFull(new ColumnFullEventArgs(xDim));
        }

        private bool ChosenSlotIsFree(int xDim, int yDim)
        {
            return Grid[xDim, yDim].GameToken == GameToken.Undefined;
        }

        private bool ColumnHasSpareSlot(int xDim)
        {
            return Grid[xDim, 0].GameToken == GameToken.Undefined;
        }

        //high number of params - refactor to two or three max
        private void PushTokenInChosenSlot(int xDim, int yDim, GameToken gameToken, Color colour)
        {
            Grid[xDim, yDim].GameToken = gameToken;
            Grid[xDim, yDim].BackColor = colour;

            OnGameTokenPlaced(new TokenPlacedEventArgs(Grid));    
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
