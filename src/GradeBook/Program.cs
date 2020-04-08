using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
        var book1 = new Book("Twoja Stara");
        book1.AddGrade(69);
        book1.AddGrade(68);
        book1.AddGrade(70);
        
        var stats = book1.GetStatistics();

        Console.WriteLine($"Book name: {book1.GetName()}");
        Console.WriteLine($"Averge: {stats.Averge}");
        Console.WriteLine($"Lowest Grade: {stats.LowestGrade}");
        Console.WriteLine($"Highest Grade: {stats.HighestGrade}");
        }
    }
}
