using Wyzwanie21;

var driver1 = new Driver("Kuuuba", "Trak");
driver1.AddGrade("Kuba");
driver1.AddGrade("16");
driver1.AddGrade(6f);
driver1.AddGrade(2.5);
driver1.AddGrade(234);
var stats = driver1.GetStats();

Console.WriteLine($"Max: {stats.Max}");
Console.WriteLine($"Min: {stats.Min}");
Console.WriteLine($"Average: {stats.Average:N2}");



/*void SetSth(out  Stats stats)
{
    stats = new Stats();
}
slowko ref przekazujesz objekt ktory mozna nadpisac
slowko out przekazujesz objekt ktory MUSISZ nadpisac
void SetSth(ref Stats stats)
SetSth(out stats);*/