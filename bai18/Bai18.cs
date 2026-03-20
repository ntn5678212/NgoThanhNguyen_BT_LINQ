using System;
using System.Collections.Generic;
using System.Linq;

namespace bai18
{
    class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }

    class Bai18
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

            var ten = students.GroupBy(s =>
            {
                if (s.Score >= 8) return "gioi";
                else if (s.Score >= 6) return "kha"; else return "trung binh";
            });

            Console.WriteLine("phan nhom sinh vien theo hoc luc gioi-kha-trung binh :");

            foreach (var group in ten)
            {
                Console.WriteLine($"\n{group.Key}:");
                foreach (var s in group)
                {
                    Console.WriteLine($"{s.Name} - {s.Score}");
                }
            }
        }
    }
}