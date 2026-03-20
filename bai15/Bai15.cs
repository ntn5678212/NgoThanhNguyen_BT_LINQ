using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_LINQ
{
    class Bai15
    {
        static void Main()
        {
            Console.WriteLine("Ngo Thanh Nguyen_2415053122330_225LTC#02");
            List<int> numbers = new List<int>() { 1, 2, 2, 3, 4, 4, 5 };
            var so = numbers.Distinct();
            Console.WriteLine("danh sach sau khi loai bo trung la");
            foreach (int n in so)
                Console.Write(n + " ");


        }
    }
}