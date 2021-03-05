using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05.DateModifier
{
    public class DateModifier
    {
        public int CalculateDifference(string data1,string data2)
        {
            var date1Arr = data1.Split()
                .Select(int.Parse)
                .ToArray();

            DateTime dateTime1 = new DateTime(date1Arr[0], date1Arr[1], date1Arr[2]);

            var date2Arr = data2.Split()
                .Select(int.Parse)
                .ToArray();

            DateTime dateTime2 = new DateTime(date2Arr[0], date2Arr[1], date2Arr[2]);

            return Math.Abs((dateTime1 - dateTime2).Days);

        }
    }
}
