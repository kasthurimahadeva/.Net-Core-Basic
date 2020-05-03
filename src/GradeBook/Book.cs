using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public List<double> Grades { get; set; }
        
        public Book()
        {
            Grades = new List<double>();
        }

        public List<double> GetGradesFromUser()
        {
            Console.WriteLine("Enter Q or q to terminate the program");
            var list = new List<double>();
            var x = Console.ReadLine();
            while (x != null && x != "Q" && x != "q")
            {
                var isDouble = double.TryParse(x, out var value);
                if (isDouble)
                {
                    list.Add(value);
                }
                Console.WriteLine("Enter Q or q to terminate the program");
                x = Console.ReadLine();
            }
            return list;
        }
        
        public void CalculateStatistics()
        {
            foreach (var grade in Grades)
            {
                Statistics.Average += grade;
                Statistics.Max = Math.Max(Statistics.Max, grade);
                Statistics.Min = Math.Min(Statistics.Min, grade);
            }
            Statistics.Average /= Grades.Count;
        }
    }
    
    public static class Statistics
    {
        public static double Average { get; set; } = 0.0;
        public static double Max { get; set; } = double.MinValue;
        public static double Min { get; set; } = double.MaxValue;
    }
}