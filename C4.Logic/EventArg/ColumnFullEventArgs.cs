using System;

namespace C4.Logic.EventArg
{
    public class ColumnFullEventArgs : EventArgs
    {
        public int ColumIndex { get; private set; }


        public ColumnFullEventArgs(int columnIndex)
        {
            ColumIndex = columnIndex;
        }
    }
}
