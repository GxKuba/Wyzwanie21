namespace Wyzwanie21
{
    public class Driver : Person
    {
        private List<float> grades= new List<float>();

        public Driver(string name, string surname, char sex)
            : base(name, surname, sex) { }
        
        
        public void AddGrade(float grade)
        {
            if(grade>=0 && grade<=100)
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
            switch(grade) 
            {
                case 'A': case 'a': this.AddGrade(100); break;
                case 'B': case 'b': this.AddGrade(80); break;
                case 'C': case 'c': this.AddGrade(60); break;
                case 'D': case 'd': this.AddGrade(40); break;
                case 'E': case 'e': this.AddGrade(20); break;
                default: throw new Exception("Wrong letter");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade,out float result))
            {
                this.AddGrade(result);
            }
            else if(char.TryParse(grade, out char charResult))
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


