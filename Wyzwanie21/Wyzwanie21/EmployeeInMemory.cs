﻿namespace Wyzwanie21
{
    public class EmployeeInMemory : EmplyeeBase
    {
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname){}

        private List<float> grades = new List<float>();

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                this.AddGrade(charResult);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A': case 'a': this.AddGrade(100); break;
                case 'B': case 'b': this.AddGrade(80); break;
                case 'C': case 'c': this.AddGrade(60); break;
                case 'D': case 'd': this.AddGrade(40); break;
                case 'E': case 'e': this.AddGrade(20); break;
                default: throw new Exception("Wrong letter");
            }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public override Stats GetStats()
        {
            var stats = new Stats();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                stats.Max = Math.Max(stats.Max, grade);
                stats.Min = Math.Min(stats.Min, grade);
                stats.Average += grade;
            }

            stats.Average /= this.grades.Count;

            switch (stats.Average)
            {
                case var average when average > 80: stats.AverageLetter = 'A'; break;
                case var average when average > 60: stats.AverageLetter = 'B'; break;
                case var average when average > 40: stats.AverageLetter = 'C'; break;
                case var average when average > 20: stats.AverageLetter = 'D'; break;
                default: stats.AverageLetter = 'E'; break;
            }

            return stats;
        }
    }
}