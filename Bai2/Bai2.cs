using System;
using System.Collections.Generic;
using System.Linq;

class Bai2
{
    static void Main()
    {
        Console.WriteLine("Ngo Thanh Nguyen_2415053122330_225LTC#02");
        List<int> so = new List<int>() { 3, 4, 6, 8, 11, 4, 99, 7, 43, 1 };
        var sol = so.Where(x => x > 5);
        Console.WriteLine("cac so lon hon 5 la");
        foreach (int x in sol)
        {
            Console.WriteLine(x);
        }
    }
}