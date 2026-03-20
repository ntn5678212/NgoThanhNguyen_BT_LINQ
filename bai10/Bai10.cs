using System;
using System.Collections.Generic;
using System.Linq;

namespace bai10
{
    class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }

    class Bai10
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

            var ten = students.OrderByDescending(s => s.Score);

            Console.WriteLine("sap xep sinh vien giam dan sau day:");
            foreach (var s in ten)
            {
                Console.WriteLine($"{s.Id}-{s.Name}-{s.Score}");
            }
        }
    }
}