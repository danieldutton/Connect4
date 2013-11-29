﻿using C4.Logic.EventArg;
using System;

namespace C4.Logic.Interfaces
{
    public interface IGameUpdater
    {
        event EventHandler<GameStatusEventArgs> GameWon;

        event EventHandler<EventArgs> GameContinues;

        event EventHandler<GameStatusEventArgs> GameDrawn;
    }
}
