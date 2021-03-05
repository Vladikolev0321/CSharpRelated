using P08.CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P08.CollectionHierarchy.Models
{
    public class MyList : IMyList
    {
        private List<string> data;
        private List<int> indexes;
        private List<string> removedElements;
        public MyList()
        {
            this.data = new List<string>();
            this.indexes = new List<int>();
            this.removedElements = new List<string>();
        }

        public int Used 
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(string element)
        {
            this.indexes.Add(0);
            this.data.Insert(0, element);
        }

        public void Remove()
        {
            string itemToRemove = this.data[0];
            this.removedElements.Add(itemToRemove);
            this.data.RemoveAt(0);
        }
        public void GetRemoved()
        {
            Console.WriteLine(string.Join(" ", this.removedElements));
        }
        public override string ToString()
        {
            return $"{string.Join(" ", this.indexes)}";
        }
    }
}
