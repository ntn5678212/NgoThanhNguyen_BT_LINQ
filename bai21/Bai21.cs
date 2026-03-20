using System;
using System.Collections.Generic;
using System.Linq;

namespace bai21
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

    class Bai21
    {
        static void Main()
        {
            Console.WriteLine("Ngo Thanh Nguyen_2415053122330_225LTC#02");
            Random rd = new Random();

            string[] names = { "An", "Binh", "Chi", "Dung", "Hieu", "Khanh", "Linh", "Minh" };
            string[] khoas = { "CNTT", "KinhTe", "NgoaiNgu", "DienTu" };

            List<Student> students = new List<Student>();

            for (int i = 1; i <= 20; i++)
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
            var svMax = students.Where(s => s.Age == students.Max(x => x.Age));
            var svMin = students.Where(s => s.Age == students.Min(x => x.Age));

            Console.WriteLine("Sinh vien co tuoi cao nhat:");
            foreach (var s in svMax)
            {
                Console.WriteLine($"{s.Id} - {s.Name} - {s.Age} tuoi - {s.khoa}");
            }

            Console.WriteLine("\nSinh vien co tuoi nho nhat:");
            foreach (var s in svMin)
            {
                Console.WriteLine($"{s.Id} - {s.Name} - {s.Age} tuoi - {s.khoa}");
            }

        }
    }
}