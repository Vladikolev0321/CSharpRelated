using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01.ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> data;
        private int currInternalIndex;

        public ListyIterator()
        {
            this.data = new List<T>();
            this.currInternalIndex = 0;
        }
        public ListyIterator(IEnumerable<T> collectionData)
        {
            this.data = new List<T>(collectionData);
        }

        public bool Move()
        {
            if(this.currInternalIndex < this.data.Count - 1)
            {
                this.currInternalIndex++;
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool HasNext()
        {
            return this.currInternalIndex < this.data.Count - 1;
        }

        public void Print()
        {
            if (!this.data.Any())
            {
                throw new InvalidOperationException("Invalid operation!");
            }

            Console.WriteLine(this.data[this.currInternalIndex]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
