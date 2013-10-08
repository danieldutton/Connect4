using System;
using C4.Logic.EventArg;

namespace C4.Logic.Interfaces
{
    public interface IReferee
    {
        event EventHandler<WinnerDetailsEventArgs> DeclareWinner;

        bool CheckRowsForWin();

        bool CheckColumnsForWin();
    }
}
