namespace Wyzwanie21
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInFile(string name, string surname) : base(name, surname){}

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
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
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
            var gradesFromFile = this.ReadGradesFromFile();
            var stats = this.CountStats(gradesFromFile);

            return stats;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
            
        }
        
        private Stats CountStats(List<float> grades)
        {
            var stats = new Stats();
            foreach (var grade in grades)
            {
                stats.AddGrade(grade);
            }
            return stats;
        }
    }
}
