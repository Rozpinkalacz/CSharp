using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    public class Book
    {   
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {   
            if(grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
                throw new ArgumentException($"Ivalid {nameof(grade)}");
        }
        public void AddGrade(char letter)
        {
           switch(letter)
           {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                case 'F':
                    AddGrade(50);
                    break;    
                default:
                    Console.WriteLine("Invalid value.");
                    break;
           }
        }
     
        public event GradeAddedDelegate GradeAdded;

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Averge = 0.0;
            result.HighestGrade = double.MinValue;
            result.LowestGrade = double.MaxValue;

            foreach(double grade in grades)
            {
                result.HighestGrade = Math.Max(result.HighestGrade, grade);
                result.LowestGrade = Math.Min(result.LowestGrade, grade);
                result.Averge += grade;
            }
            result.Averge /= grades.Count;

            switch(result.Averge)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = '6';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }

        public string Name
        {
           get;
           private set;
        }
        List<double> grades; 
    }
}