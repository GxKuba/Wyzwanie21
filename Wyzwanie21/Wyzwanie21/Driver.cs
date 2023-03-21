
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
            this.grades.Add(grade);
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
