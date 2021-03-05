using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_of_Strings
{
    class StackOfStrings:Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public void AddRange(IEnumerable<string> values)
        {
            foreach (var value in values)
            {
                this.Push(value);
            }
        }
    }
}
