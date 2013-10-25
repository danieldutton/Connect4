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
        
        Player RedPlayer { get; set; }

        Player YellowPlayer { get; set; }

        bool ChosenSlotIsFree(int rowNo, int columnNo);

        bool ColumnHasSpareSlot(int columnNo);

        void TakeMove(int columnNo);

        bool GameTokenIsRed(int rowNo, int columnNo);

        bool GameTokenIsYellow(int rowNo, int columnNo);

        bool GameTokenIsUndefined(int rowNo, int columnNo);

        void PushTokenInSlot(int rowNo, int columnNo, GameToken gameToken, Color colour);
    }
}
