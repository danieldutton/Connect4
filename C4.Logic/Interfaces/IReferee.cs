using C4.Logic.EventArg;
using System;

namespace C4.Logic.Interfaces
{
    public interface IReferee
    {
        event EventHandler<GameStatusEventArgs> GameWon;

        event EventHandler<EventArgs> GameNotWon;

        event EventHandler<EventArgs> GameDrawn;

        void CheckForWinner();

        bool CheckForDraw();
    }
}
