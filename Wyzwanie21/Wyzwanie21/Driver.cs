
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
            float gradeAsFloat = (float)gradeAsFloat;
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
                stats.Max = Math.Max(stats.Max, grade);
                stats.Min = Math.Min(stats.Min, grade);
                stats.Average+= grade;
            }
            stats.Average/= this.grades.Count;

            return stats;
        }
    }
}

/* Stworzyc kilka metod do przjecia ocen w roznych formatach
 * double, long, ulong, bool
 */
