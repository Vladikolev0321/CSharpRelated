using System;
using System.Collections.Generic;
using System.Text;

namespace P01.GenericBoxofString
{
    public class Box<T> where T: IComparable
    {
        public Box(List<T> value)
        {
            this.Values = value;
        }
        public List<T> Values { get; set; }

        public void SwapElementsByIndex(List<T> items, int index1, int index2)
        {
            T temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }
        public int CountGreaterElements(List<T> list,T elementToCompare)
        {
            int counter = 0;
            foreach (var element in list)
            {
                if(elementToCompare.CompareTo(element) < 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.Values)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}
