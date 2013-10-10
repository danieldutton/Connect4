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
                            PushTokenInSlot(xDim, i, GameToken.Yellow, Color.Yellow);
                            AllowTurnRedPlayer();
                        }
                        else if (PlayerRed.HasCurrentTurn)
                        {
                            PushTokenInSlot(xDim, i, GameToken.Red, Color.Red);
                            AllowTurnYellowPlayer();
                        }
                        break;
                    }
                }
            }
            else OnColumnFull(new ColumnFullEventArgs(xDim));
        }

        public bool ColumnHasSpareSlot(int xDim)
        {
            return Grid[xDim, 0].GameToken == GameToken.Undefined;
        }

        public bool ChosenSlotIsFree(int xDim, int yDim)
        {
            return Grid[xDim, yDim].GameToken == GameToken.Undefined;
        }

        public void PushTokenInSlot(int xDim, int yDim, GameToken gameToken, Color colour)
        {
            Grid[xDim, yDim].GameToken = gameToken;
            Grid[xDim, yDim].BackColor = colour;

            OnGameTokenPlaced(new TokenPlacedEventArgs(Grid));
        }

        private void AllowTurnRedPlayer()
        {
            PlayerRed.HasCurrentTurn = true;
            PlayerYellow.HasCurrentTurn = false;
        }

        private void AllowTurnYellowPlayer()
        {
            PlayerRed.HasCurrentTurn = false;
            PlayerYellow.HasCurrentTurn = true;
        }

        public bool GameTokenIsRed(int xDim, int yDim)
        {
            return Grid[xDim, yDim].GameToken == GameToken.Red;
        }

        public bool GameTokenIsYellow(int xDim, int yDim)
        {
            return Grid[xDim, yDim].GameToken == GameToken.Yellow;
        }

        public bool GameTokenIsUndefined(int xDim, int yDim)
        {
            return Grid[xDim, yDim].GameToken == GameToken.Undefined;
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
