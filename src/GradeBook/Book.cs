using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Book
    {
        private List<double> Grades;
        
        public Book()
        {
            Grades = new List<double>();
        }
        
        public void AddGrades(List<Double> list)
        {
            foreach (var grade in list.Where(grade => grade >= 0 && grade <= 100))
            {
                Grades.Add(grade);
            }
        }
        public Statistics CalculateStatistics()
        {
            var statistics = new Statistics();
            foreach (var grade in Grades)
            {
                statistics.Average += grade;
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
            }
            statistics.Average /= Grades.Count;
            return statistics;
        }
    }

    public class Statistics
    {
        public double Average { get; set; } = 0.0;
        public double Max { get; set; } = double.MinValue;
        public double Min { get; set; } = double.MaxValue;
    }
}