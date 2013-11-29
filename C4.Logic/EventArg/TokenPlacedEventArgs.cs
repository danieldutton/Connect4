using C4.Model;
using System;

namespace C4.Logic.EventArg
{
    public sealed class TokenPlacedEventArgs : EventArgs
    {
        public Tile[,] CurrentGrid { get; private set; }

        public TokenPlacedEventArgs(Tile[,] currentGrid)
        {
            CurrentGrid = currentGrid;
        }
    }
}
