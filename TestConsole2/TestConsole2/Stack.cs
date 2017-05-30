using System;
using System.Collections.Generic;

namespace TestConsole2
{
    public class Stack
    {
        private readonly List<object> _arr = new List<object>();

        public void Push(object obj)
        {
            if (obj is null)
                throw new InvalidOperationException("Null object cannot be added to stack");

            this._arr.Add(obj);
        }

        public object Pop()
        {
            if (this._arr.Count <= 0)
                throw new InvalidOperationException("End of stack reached");

            object obj = this._arr[this._arr.Count - 1];
            this._arr.RemoveAt(this._arr.Count - 1);

            return obj;
        }

        public void Clear()
        {
            this._arr.Clear();
        }
    }
}
