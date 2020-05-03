using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            var list = book.GetGradesFromUser();
            book.Grades = list;
            book.CalculateStatistics();
            Console.WriteLine($"Average is {Statistics.Average}");
            Console.WriteLine($"Maximum is {Statistics.Max}");
            Console.WriteLine($"Minimum is {Statistics.Min}");
        }
    }
}
