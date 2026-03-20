
using System;
using System.Collections.Generic;
using System.Linq;

namespace bai24
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string khoa { get; set; }
        public double Score { get; set; }
        public int Year { get; set; }
    }

    class Bai24
    {
        static void Main()
        {
            Console.WriteLine("Ngo Thanh Nguyen_2415053122330_225LTC#02");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Random rd = new Random();

            string[] names = { "An", "Binh", "Chi", "Dung", "Hieu", "Khanh", "Linh", "Minh" };
            string[] khoas = { "CNTT", "KinhTe", "NgoaiNgu", "DienTu" };

            List<Student> students = new List<Student>();


            for (int i = 1; i <= 10; i++)
            {
                students.Add(new Student
                {
                    Id = i,
                    Name = names[rd.Next(names.Length)],
                    Age = rd.Next(18, 25),
                    khoa = khoas[rd.Next(khoas.Length)],
                    Score = Math.Round(rd.NextDouble() * 10, 2),
                    Year = rd.Next(1, 5)
                });
            }
            Console.WriteLine("===== DANH SACH SINH VIEN =====\n");

            foreach (var s in students)
            {
                Console.WriteLine($"ID: {s.Id,-3} | Ten: {s.Name,-6} | Tuoi: {s.Age,-2} | Khoa: {s.khoa,-10} | Diem: {s.Score,5}");
            }
            var sv = students.Where(s => s.Year>=1 && s.Year<=3);
            Console.WriteLine("danh sach ca sinh vien tu nam 1 toi nam 3 la");
            foreach (var s in sv)
                Console.WriteLine($"{s.Id}-{s.Name}-{s.Age}-{s.Score}-{s.khoa}-{s.Year}");

        }
    }
}
