﻿namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.GetGradesFromUser();
            book.CalculateStatistics();
        }
    }
}
