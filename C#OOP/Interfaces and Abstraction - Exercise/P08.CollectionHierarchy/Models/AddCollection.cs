using P08.CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P08.CollectionHierarchy.Models
{
    public class AddCollection : IAddable
    {
        private ICollection<string> data;
        private ICollection<int> indexes;
        public AddCollection()
        {
            this.data = new List<string>();
            this.indexes = new List<int>();
        }

        public void Add(string element)
        {
            int index = this.data.Count;
            this.indexes.Add(index);
            this.data.Add(element);
        }

        public override string ToString()
        {
            return $"{string.Join(" ",this.indexes)}";
        }
    }
}
