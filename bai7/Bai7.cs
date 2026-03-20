using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_LINQ
{
    class Bai7
    {
        static void Main()
        {
            Console.WriteLine("Ngo Thanh Nguyen_2415053122330_225LTC#02");
            List<int> list = new List<int>() { 3,4,5,7,8,33};
            bool kt=list.Any(x => x > 10);
            Console.WriteLine(kt);
        }
    }
}
