using System;
using Xunit;

namespace GradeBook.Tests
{
    public class StatsTest
    {
        [Fact]
        public void CanCalculatesStatistics()
        {
            var book = new Book("GradeBook 1");
            book.AddGrade(40);
            book.AddGrade(41);
            book.AddGrade(43);
            book.AddGrade(44);

            var stats = book.GetStatistics();
            Assert.Equal(40, stats.LowestGrade);
            Assert.Equal(44, stats.HighestGrade);
            Assert.Equal(42, stats.Averge);
            Assert.Equal('F', stats.Letter);
        }
    }
}
