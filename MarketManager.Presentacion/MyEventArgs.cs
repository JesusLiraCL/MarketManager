using System;

namespace MarketManager.Presentacion
{
    internal class MyEventArgs : EventArgs
    {
        private int rowIndex;

        public MyEventArgs(int rowIndex)
        {
            this.rowIndex = rowIndex;
        }
    }
}