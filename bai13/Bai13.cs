using System;
using System.Collections.Generic;
using System.Linq;

namespace bai13
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }

    class Bai13
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
            var top = students.FirstOrDefault(s => s.Score > 7);

            if (top != null)
            {
                Console.WriteLine($"Sinh vien dau tien >7 diem: {top.Name}");
            }
        }
    }
}