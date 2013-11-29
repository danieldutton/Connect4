using C4.Model;
using System;

namespace C4.Presentation.EventArg
{
    public sealed class PlayersConfirmedEventArgs : EventArgs
    {
        public Player YellowPlayer { get; private set; }

        public Player RedPlayer { get; private set; }


        public PlayersConfirmedEventArgs(Player yellowPlayer, Player redPlayer)
        {
            YellowPlayer = yellowPlayer;
            RedPlayer = redPlayer;
        }
    }
}
