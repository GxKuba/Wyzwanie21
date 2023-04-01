
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
            //walidacja
            if(grade>=0 && grade<=100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            //rzutowanie
            //int valueInInt = (int)grade;
            //float f = valueInInt;
            //zaokragla w dol 3.9 -> 3
            //Math.Ceiling  zaokraglanie do gory
            //Math.Floor zaokraglanie do dolu
            if(float.TryParse(grade,out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
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

        public Stats GetStats()
        {
            var stats = new Stats();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min= float.MaxValue;
            
            foreach (var grade in this.grades)
            {
                //break
                //continue - pomija dalsza czesc petli
                //goto - przeskok do konkretnego miejsca w kodzie (nie uzywac)

                stats.Max = Math.Max(stats.Max, grade);
                stats.Min = Math.Min(stats.Min, grade);
                stats.Average+= grade;
            }
            
            stats.Average /= this.grades.Count;
            return stats;
        }

        public Stats GetStatsWithDoWhile()
        {
            var stats = new Stats();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;
            int index = 0;
            do
            {
                stats.Max = Math.Max(stats.Max, this.grades[index]);
                stats.Min = Math.Min(stats.Min, this.grades[index]);
                stats.Average += grades[index];
                index++;
            } while (index < this.grades.Count);
            stats.Average /= this.grades.Count;
            return stats;
        }

        public Stats GetStatsWithWhile()
        {
            var stats = new Stats();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;
            int index = 0;
            while (index < this.grades.Count)
            {
                stats.Max = Math.Max(stats.Max, this.grades[index]);
                stats.Min = Math.Min(stats.Min, this.grades[index]);
                stats.Average += grades[index];
                index++;
            } ;
            stats.Average /= this.grades.Count;
            return stats;
        }

        public Stats GetStatsWithFor()
        {
            var stats = new Stats();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;
            
            for(int i=0; i < this.grades.Count; i++)
            {
                stats.Max = Math.Max(stats.Max, this.grades[i]);
                stats.Min = Math.Min(stats.Min, this.grades[i]);
                stats.Average += grades[i];
                
            };
            stats.Average /= this.grades.Count;
            return stats;
        }
    }
}


