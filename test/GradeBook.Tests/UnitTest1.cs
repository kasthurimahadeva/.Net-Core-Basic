using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var list = new List<double> {53.5, 10.5, 12};
            var book = new Book();
            book.AddGrades(list);
            var result = book.CalculateStatistics();
            Assert.Equal(list.Average(), result.Average);
            Assert.Equal(list.Max(), result.Max);
            Assert.Equal(list.Min(), result.Min);
        }
    }
}
