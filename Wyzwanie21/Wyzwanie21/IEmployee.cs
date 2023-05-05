namespace Wyzwanie21
{
    public interface IEmployee
    {
        string Name { get;}
        string Surname { get;}
        Stats GetStats();
        void AddGrade(string grade);
        void AddGrade(char grade);
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);

    }

}
    

   
