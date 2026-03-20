using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_LINQ
{
    class Bai19
    {
        static void Main()
        {
            Console.WriteLine("Ngo Thanh Nguyen_2415053122330_225LTC#02");
            List<int> numbers = new List<int>() { 1, 2, 2, 3, 4, 5, 8, 9 };
            var max = numbers.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key;
            Console.WriteLine("so nguyen xuat hien nhieu nhat la:");
            Console.Write(max);


        }
    }
}