using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_of_Strings
{
    public static class CollectionExtensions
    {
        public static bool IsEmpty<T>(this ICollection<T> collection)
        {
            return collection.Count == 0;
        }
        
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> values)
        {
            foreach (var value in values)
            {
                collection.Add(value);
            }
        }
    }
}
