using System;

namespace C4.Logic.EventArg
{
    public class ColumnFullEventArgs : EventArgs
    {
        public int ColumNumber { get; private set; }

        public ColumnFullEventArgs(int columnIndex)
        {
            ColumNumber = columnIndex;
        }
    }
}
