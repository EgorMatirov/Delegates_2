using System;

namespace Delegates_2
{
    public class Logger
    {
        public Logger(IModel model)
        {
            model.OnPut += LogPutEvent;
            model.OnGet += LogGetEvent;
            model.OnInsertColumn += LogInsertColumnEvent;
            model.OnInsertRow += LogInsertRowEvent;
        }

        public void LogPutEvent(object sender, PutEventArgs args)
        {
            Console.WriteLine($"Put: {args.Row}, {args.Column}, {args.Value}");
        }

        public void LogInsertRowEvent(object sender, InsertRowEventArgs args)
        {
            Console.WriteLine($"Inserted row at {args.Index}");
        }

        public void LogInsertColumnEvent(object sender, InsertColumnEventArgs args)
        {
            Console.WriteLine($"Inserted column at {args.Index}");
        }

        public void LogGetEvent(object sender, GetEventArgs args)
        {
            Console.WriteLine($"Got value at {args.Row}, {args.Column}");
        }
    }
}