using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = GetGradesFromUser();
            var book = new Book();
            book.AddGrades(list);
            var result = book.CalculateStatistics();
            Console.WriteLine($"Average is {result.Average}");
            Console.WriteLine($"Maximum is {result.Max}");
            Console.WriteLine($"Minimum is {result.Min}");
        }
        
        private static List<double> GetGradesFromUser()
        {
            var list = new List<double>();
            while (true)
            {
                Console.WriteLine("Enter Q or q to terminate the program");
                var userInput = Console.ReadLine();
                if (userInput.ToLower() == "q") break;
                var isDouble = double.TryParse(userInput, out var value);
                if (isDouble)
                {
                    list.Add(value);
                }
            }
            return list;
        }
    }
}
