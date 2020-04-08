using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {   
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public string GetName()
        {
            return name;
        }
        public List<double> GetGrades()
        {
            return grades;
        }

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

            return result;
        }

        List<double> grades; 
        string name;
    }
}