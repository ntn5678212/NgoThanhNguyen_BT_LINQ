using System;
using System.Collections.Generic;
using System.Linq;

namespace bai14
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }

    class Bai14
    {
        static void Main()
        {
            Console.WriteLine("Ngo Thanh Nguyen_2415053122330_225LTC#02");
            List<Student> students = new List<Student>()
        {
            new Student{Id=1, Name="An", Score=8},
            new Student{Id=2, Name="Binh", Score=6},
            new Student{Id=3, Name="Chi", Score=9},
            new Student{Id=4, Name="Dung", Score=7}
        };

            var rot = students.Where(s => s.Score < 5);

            if (rot.Any())
            {
                Console.WriteLine("Nhung sinh vien bi rot la:");
                foreach (var s in rot)
                {
                    Console.WriteLine(s.Name);
                }
            }
            else
            {
                Console.WriteLine("Khong co sinh vien rot mon");
            }
        }
    }
}
