using System;
using System.Collections.Generic;
using System.Linq;

namespace bai23
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

    class Bai23
    {
        static void Main()
        {
            Console.WriteLine("Ngo Thanh Nguyen_2415053122330_225LTC#02");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Random rd = new Random();

            string[] names = { "An", "Binh", "Chi", "Dung", "Hieu", "Khanh", "Linh", "Minh" };
            string[] khoas = { "CNTT", "KinhTe", "NgoaiNgu", "DienTu" };

            List<Student> students = new List<Student>();


            for (int i = 1; i <= 15; i++)
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
            var top10 = students.OrderByDescending(s => s.Score).Take(10).ToList();

            Console.WriteLine("===== TOP 10 SINH VIEN DIEM CAO NHAT TOAN TRUONG =====\n");

            foreach (var s in top10)
            {
                Console.WriteLine($"ID: {s.Id,-3} | Ten: {s.Name,-6} | Khoa: {s.khoa,-10} | Diem: {s.Score,5}");
            }
        }
    }
}
