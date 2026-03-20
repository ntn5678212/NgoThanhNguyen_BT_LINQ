using System;
using System.Collections.Generic;
using System.Linq;

class Bai4
{
    static void Main()
    {
        Console.WriteLine("Ngo Thanh Nguyen_2415053122330_225LTC#02");
        List<int> so = new List<int>() { 3, 4, 6, 8, 11, 4, 99, 7, 43, 1 };
        var sol = so.OrderByDescending(x => x);
        Console.WriteLine("cac so duoc sap xep tang dan la:");
        foreach (int x in sol)
        {
            Console.WriteLine(x);
        }
    }
}