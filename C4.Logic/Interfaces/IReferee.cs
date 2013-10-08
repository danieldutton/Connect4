using C4.Logic.EventArg;
using C4.Model;
using System;

namespace C4.Logic.Interfaces
{
    public interface IReferee
    {
        event EventHandler<WinnerDetailsEventArgs> DeclareWinner;

        Player PlayerRed{get; set;}

        Player PlayerYellow{get;set;}

        bool CheckRowsForWin();

        bool CheckColumnsForWin();

        bool CheckDiagonalRowsForWin();
    }
}
