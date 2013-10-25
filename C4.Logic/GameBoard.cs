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

        public Player YellowPlayer { get; set; }

        public Player RedPlayer { get; set; }


        public static GameBoard GetGameInstance()
        {
            return GameBoardInstance ?? (GameBoardInstance = new GameBoard());
        }

        public void TakeMove(int columnNo)
        {
            if (ColumnHasSpareSlot(columnNo))
            {
                for (int i = 5; i < Grid.GetLength(0); i--)
                {
                    if (ChosenSlotIsFree(i, columnNo))
                    {
                        if (RedPlayer.HasCurrentTurn)
                        {
                            PushTokenInSlot(i, columnNo, GameToken.Red, Color.Red);
                            AllowTurnRedPlayer();
                        }
                        else if (YellowPlayer.HasCurrentTurn)
                        {
                            PushTokenInSlot(i, columnNo, GameToken.Yellow, Color.Yellow);
                            AllowTurnYellowPlayer();
                        }
                        break;
                    }
                }
            }
            else OnColumnFull(new ColumnFullEventArgs(columnNo));
        }

        public bool ColumnHasSpareSlot(int columnNo)
        {
            return Grid[0, columnNo].GameToken == GameToken.Undefined;
        }

        public bool ChosenSlotIsFree(int rowNo, int columnNo)
        {
            return Grid[rowNo, columnNo].GameToken == GameToken.Undefined;
        }

        public void PushTokenInSlot(int rowNo, int columnNo, GameToken gameToken, Color colour)
        {
            Grid[rowNo, columnNo].GameToken = gameToken;
            Grid[rowNo, columnNo].BackColor = colour;

            OnGameTokenPlaced(new TokenPlacedEventArgs(Grid));
        }

        private void AllowTurnRedPlayer()
        {
            YellowPlayer.HasCurrentTurn = true;
            RedPlayer.HasCurrentTurn = false;
        }

        private void AllowTurnYellowPlayer()
        {
            YellowPlayer.HasCurrentTurn = false;
            RedPlayer.HasCurrentTurn = true;
        }

        public bool GameTokenIsRed(int rowNo, int columnNo)
        {
            return Grid[rowNo, columnNo].GameToken == GameToken.Red;
        }

        public bool GameTokenIsYellow(int rowNo, int columnNo)
        {
            return Grid[rowNo, columnNo].GameToken == GameToken.Yellow;
        }

        public bool GameTokenIsUndefined(int rowNo, int columnNo)
        {
            return Grid[rowNo, columnNo].GameToken == GameToken.Undefined;
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
