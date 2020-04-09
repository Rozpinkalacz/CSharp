
using System;

namespace GradeBook
{
    public class Statistics
    {
        public Statistics()
        {
            Sum = 0.0;
            Count = 0;
            HighestGrade = double.MinValue;
            LowestGrade = double.MaxValue;
        }

        public void Add(double number)
        {
            Sum += number;
            HighestGrade = Math.Max(HighestGrade, number);
            LowestGrade = Math.Min(LowestGrade, number);
            Count++;
        }


        public double Averge
        {
            get { return Sum / Count; }
        }
        public double LowestGrade;
        public double HighestGrade;
        public char Letter
        {
            get
            {
                switch (Averge)
                {
                    case var d when d >= 90.0:
                        return 'A';
                    case var d when d >= 80.0:
                        return 'B';
                    case var d when d >= 70.0:
                        return 'C';
                    case var d when d >= 60.0:
                        return 'D';
                    default:
                        return 'F';
                }
            }
        }
        public double Sum;
        public int Count;
    }
}