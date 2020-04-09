using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiskBook("Twoja Stara");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine(book);

            Console.WriteLine($"Book name: {book.Name}");
            Console.WriteLine($"Averge: {stats.Averge}");
            Console.WriteLine($"Lowest Grade: {stats.LowestGrade}");
            Console.WriteLine($"Highest Grade: {stats.HighestGrade}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
            do
            {
                Console.Write("Please enter the grade or 'Q' to stop: ");
                var userInput = Console.ReadLine();
                if (userInput == "Q") break;
                try
                {
                    var grade = double.Parse(userInput);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}
