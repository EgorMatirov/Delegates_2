using System;

namespace Delegates_2
{
    public class PutEventArgs : EventArgs
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int Value { get; set; }
    }

    public class InsertRowEventArgs : EventArgs
    {
        public int Index { get; set; }
    }

    public class InsertColumnEventArgs : EventArgs
    {
        public int Index { get; set; }
    }

    public class GetEventArgs : EventArgs
    {
        public int Row { get; set; }
        public int Column { get; set; }
    }

    public delegate void PuttedEventHandler(object sender, PutEventArgs args);
    public delegate void InsertRowEventHandler(object sender, InsertRowEventArgs args);
    public delegate void InsertColumnEventHandler(object sender, InsertColumnEventArgs args);
    public delegate void GetEventHandler(object sender, GetEventArgs args);

    public class Model : IModel
    {
        public event PuttedEventHandler OnPut;
        public event InsertRowEventHandler OnInsertRow;
        public event InsertColumnEventHandler OnInsertColumn;
        public event GetEventHandler OnGet;

        public void Put(int row, int column, int value)
        {
            // Do something.
            OnPut?.Invoke(this, new PutEventArgs { Column = column, Row = row, Value = value });
        }

        public void InsertRow(int rowIndex)
        {
            // Do something.
            OnInsertRow?.Invoke(this, new InsertRowEventArgs { Index = rowIndex });
        }

        public void InsertColumn(int columnIndex)
        {
            // Do something.
            OnInsertColumn?.Invoke(this, new InsertColumnEventArgs { Index = columnIndex });
        }

        public void Get(int row, int column)
        {
            // Do something.
            OnGet?.Invoke(this, new GetEventArgs { Column = column, Row = row });
        }
    }
}
