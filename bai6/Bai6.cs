using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_LINQ
{
   class Bai6
    {
        static void Main()
        {
            Console.WriteLine("Ngo Thanh Nguyen_2415053122330_225LTC#02");
            List<int> numbers=new List<int>() { 1,2,3,4,5,6,7,8,9};
            var so=numbers.Where(x => x%2==0).Count();
            Console.WriteLine($"So luong so chan: {so}");

        }
    }
}
