using Wyzwanie21;

Console.WriteLine("Witamy w Programie XYZ do oceny pracownikow");
Console.WriteLine("===========================================");
Console.WriteLine();

var driver1 = new Driver("Kuba", "Tak",'M');

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
        driver1.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catch: {e.Message}");
    }
    

}

var stats = driver1.GetStats();
Console.WriteLine($"AVG: {stats.Average:N2}");
Console.WriteLine($"MIN: {stats.Min}");
Console.WriteLine($"MAX: {stats.Max}");

//Napisac testy 