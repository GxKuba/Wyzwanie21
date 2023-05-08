using Wyzwanie21;

Console.WriteLine("Witamy w Programie XYZ do oceny pracownikow");
Console.WriteLine("===========================================");
Console.WriteLine();

var employe = new EmployeeInMemory("Kuba", "Tak");
employe.GradeAdded += EmployeGradeAdded;
void EmployeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("New grade has been added");
}


while (true)
{
    Console.WriteLine("Podaj ocene pracownika");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employe.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catch: {e.Message}");
    }
    

}

var stats = employe.GetStats();
Console.WriteLine($"AVG: {stats.Average:N2}");
Console.WriteLine($"MIN: {stats.Min}");
Console.WriteLine($"MAX: {stats.Max}");
