using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> Grades { get; }
        
        public Book()
        {
            Grades = new List<double>();
        }

        public void GetGradesFromUser()
        {
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter {i + 1}th Num (0 - 100) : ");
                var x = double.Parse(Console.ReadLine() ?? "0.0");
                if (x >= 0 && x <= 100)
                {
                    Grades.Add(x);
                }
                else
                {
                    Console.WriteLine("Enter the grade between 0 - 100");
                    i--;
                }
            }
        }
        
        public void CalculateStatistics()
        {
            var statistics = new Statistics();
            foreach (var grade in Grades)
            {
                statistics.Average += grade;
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
            }
            statistics.Average /= Grades.Count;
            Console.WriteLine($"Average is {statistics.Average}");
            Console.WriteLine($"Maximum is {statistics.Max}");
            Console.WriteLine($"Minimum is {statistics.Min}");
        }
    }
    
    public class Statistics
    {
        public double Average { get; set; } = 0.0;
        public double Max { get; set; } = double.MinValue;
        public double Min { get; set; } = double.MaxValue;
    }
}