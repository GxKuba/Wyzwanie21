
using System.Diagnostics;

namespace Wyzwanie21
{
    public class Driver
    {
        private List<float> grades= new List<float>();

        public Driver(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get;private set; }
        public void AddGrade(float grade)
        {
            if(grade>=0 && grade<=100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }

        public void AddGrade(char grade)
        {
            switch(grade) 
            {
                case 'A': case 'a': this.AddGrade(100); break;
                case 'B': case 'b': this.AddGrade(80); break;
                case 'C': case 'c': this.AddGrade(60); break;
                case 'D': case 'd': this.AddGrade(40); break;
                case 'E': case 'e': this.AddGrade(20); break;
                default: Console.WriteLine("Wrong letter"); break;
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade,out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
            
        }


        public Stats GetStats()
        {
            var stats = new Stats();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min= float.MaxValue;
            
            foreach (var grade in this.grades)
            {
                stats.Max = Math.Max(stats.Max, grade);
                stats.Min = Math.Min(stats.Min, grade);
                stats.Average+= grade;
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


