using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ngo Thanh Nguyen_2415053122330_225LTC#02");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        var result = numbers.Where(x => x % 2 == 0);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
