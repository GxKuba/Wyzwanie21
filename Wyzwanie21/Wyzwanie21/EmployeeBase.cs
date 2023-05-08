using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyzwanie21
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract Stats GetStats();
    }
}
