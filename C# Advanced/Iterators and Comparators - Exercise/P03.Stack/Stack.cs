using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private readonly List<T> data;
        
        public Stack()
        {
            this.data = new List<T>();
        }

        public void Push(IEnumerable<T> elements)
        {
            foreach (var element in elements)
            {
                this.Push(element);
            }
        }
        public void Push(T element)
        {
            this.data.Add(element);
        }
        public T Pop()
        {
            if(this.data.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            
            T removedElement =  this.data[this.data.Count - 1];
            this.data.RemoveAt(this.data.Count - 1);
            return removedElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = this.data.Count - 1;i >= 0; i--)
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
