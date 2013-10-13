using C4.Logic.EventArg;
using C4.Model;
using System;
using System.Drawing;

namespace C4.Logic.Interfaces
{
    public interface IGameBoard
    {
        event EventHandler<TokenPlacedEventArgs> GameTokenPlaced;

        Tile[,] Grid { get; set; }

        bool ChosenSlotIsFree(int xDim, int yDim);

        bool ColumnHasSpareSlot(int xDim);

        bool GameTokenIsRed(int xDim, int yDim);

        bool GameTokenIsYellow(int xDim, int yDim);

        bool GameTokenIsUndefined(int xDim, int yDim);

        void PushTokenInSlot(int xDim, int yDim, GameToken gameToken, Color colour);
    }
}
