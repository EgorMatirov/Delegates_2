namespace Delegates_2
{
    public interface IModel
    {
        event GetEventHandler OnGet;
        event InsertColumnEventHandler OnInsertColumn;
        event InsertRowEventHandler OnInsertRow;
        event PuttedEventHandler OnPut;

        void Get(int row, int column);
        void InsertColumn(int columnIndex);
        void InsertRow(int rowIndex);
        void Put(int row, int column, int value);
    }
}