using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_LINQ
{
    class bai5
    {
        static void Main()
        {
            Console.WriteLine("Ngo Thanh Nguyen_2415053122330_225LTC#02");
            List<int> numbers = new List<int> { 2, 3, 4, 5, 6 };
            var so = numbers.Select(x => x * x);
            Console.WriteLine("cac so sau khi binh phuong len la");
            foreach (int x in so) 
                Console.Write(x+" ");
        }
    }
   

}
