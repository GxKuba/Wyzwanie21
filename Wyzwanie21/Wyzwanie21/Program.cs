using Wyzwanie21;

Console.WriteLine("Witamy w Programie XYZ do oceny pracownikow");
Console.WriteLine("===========================================");
Console.WriteLine();

var driver1 = new Driver("Kuba", "Tak");
while (true)
{
    Console.WriteLine("Podaj ocene pracownika");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }

    if(char.TryParse(input, out char charInput))
    {
        driver1.AddGrade(charInput);
    }
    else
    {
        driver1.AddGrade(input);
    }

}

var stats = driver1.GetStats();
Console.WriteLine($"AVG: {stats.Average:N2}");
Console.WriteLine($"MIN: {stats.Min}");
Console.WriteLine($"MAX: {stats.Max}");

//Napisac testy 