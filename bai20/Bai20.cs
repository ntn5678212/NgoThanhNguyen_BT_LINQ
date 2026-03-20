using System;
using System.Linq;
using System.Collections.Generic;

namespace bai20
{
    class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }

    class Bai20
    {
        static void Main()
        {
            Console.WriteLine("Ngo Thanh Nguyen_2415053122330_225LTC#02");
            List<student> students = new List<student>()
        {
            new student{Id=1, Name="An", Score=8},
            new student{Id=2, Name="Binh", Score=6},
            new student{Id=3, Name="Chi", Score=9},
            new student{Id=4, Name="Dung", Score=7}
        };

            var top = students.OrderByDescending(g => g.Score).Take(3);
            foreach (var s in top)
            {
                Console.WriteLine($"{s.Id} - {s.Name} - {s.Score}");
            }
        }
    }
}