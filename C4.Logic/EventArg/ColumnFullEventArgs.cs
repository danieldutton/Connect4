using System;

namespace C4.Logic.EventArg
{
    public sealed class ColumnFullEventArgs : EventArgs
    {
        public int ColumNumber { get; private set; }

        public ColumnFullEventArgs(int columnIndex)
        {
            ColumNumber = columnIndex;
        }
    }
}
