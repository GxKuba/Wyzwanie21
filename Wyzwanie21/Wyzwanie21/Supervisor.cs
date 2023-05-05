using System.ComponentModel.Design;

namespace Wyzwanie21
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
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

        public void AddGrade(char grade)
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

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(string grade)
        {
            if (grade.Contains("-"))
            {
                switch (grade)
                {
                    case "6-": case "-6": this.AddGrade(95); break;
                    case "5-": case "-5": this.AddGrade(75); break;
                    case "4-": case "-4": this.AddGrade(55); break;
                    case "3-": case "-3": this.AddGrade(35); break;
                    case "2-": case "-2": this.AddGrade(15); break;
                    default: throw new Exception("Out of range minus(-) value");
                }
            }
            else if (grade.Contains("+"))
            {
                switch (grade)
                {
                    case "5+": case "+5": this.AddGrade(85); break;
                    case "4+": case "+4": this.AddGrade(65); break;
                    case "3+": case "+3": this.AddGrade(45); break;
                    case "2+": case "+2": this.AddGrade(25); break;
                    case "1+": case "+1": this.AddGrade(5); break;
                    default: throw new Exception("Out of range plus(+) value");
                }
            }
            else if (float.TryParse(grade, out float result))
            {
                switch (result)
                {
                    case 6: this.AddGrade(100); break;
                    case 5: this.AddGrade(80); break;
                    case 4: this.AddGrade(60); break;
                    case 3: this.AddGrade(40); break;
                    case 2: this.AddGrade(20); break;
                    case 1: this.AddGrade(0); break;
                    default: this.AddGrade(result); break;
                }
                
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

        public Stats GetStats()
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

