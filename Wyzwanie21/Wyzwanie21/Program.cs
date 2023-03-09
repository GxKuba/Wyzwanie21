using Wyzwanie21;


User user1 = new User("Damian", "pasik");
user1.AddScore(5);
user1.AddScore(10);
user1.AddScore(8);
var result = user1.Result;


//Dzien 6 zadanie domowe

Employee emp1 = new Employee("Andrzej", "Krzeslo",20);
Employee emp2 = new Employee("Henryk", "Taboret",30);
Employee emp3 = new Employee("Leonard", "Kalendarz",26);
Random rnd = new Random();
for (int i = 0;i < 5; i++)
{
    emp1.AddPoint(rnd.Next(10));
    emp2.AddPoint(rnd.Next(10));
    emp3.AddPoint(rnd.Next(10));
}

var result1 = emp1.Result;
var result2 = emp2.Result;
var result3 = emp3.Result;

if (result1 >= result2 && result1 >= result3)
{
    Console.WriteLine($"{emp1.Name} {emp1.Surname} Lat {emp1.Age} Zdobył {emp1.Result} punktów");
}
if (result2 >= result1 && result2 >= result3)
{
    Console.WriteLine($"{emp2.Name} {emp2.Surname} Lat {emp2.Age} Zdobył {emp2.Result} punktów");
}
if (result3 >= result2 && result3 >= result1)
{
    Console.WriteLine($"{emp3.Name} {emp3.Surname} Lat {emp3.Age} Zdobył {emp3.Result} punktów");
}

int max = 0;
if (result2 > max)
{
    max = result2;
}
if (result3 > max)
{
    max = result3;
}

if (result1 == max)
{
    Console.WriteLine($"{emp1.Name} {emp1.Surname} Lat {emp1.Age} Zdobył {emp1.Result} punktów");
}
else if(result2 == max)
{
    Console.WriteLine($"{emp2.Name} {emp2.Surname} Lat {emp2.Age} Zdobył {emp2.Result} punktów");
}
else
{
    Console.WriteLine($"{emp3.Name} {emp3.Surname} Lat {emp3.Age} Zdobył {emp3.Result} punktów");
}

//Zrobic ladniej z pomoca Adama

List<Employee> users = new List<Employee>()
{
    emp1,emp2,emp3
};

int maxResult = 0;
Employee empMax = null;

foreach(var user in users)
{
    if (user.Result > maxResult)
    {
        empMax = user;
        maxResult = user.Result;
    }
}

Console.WriteLine(emp1.Result+" "+ emp2.Result+" "+emp3.Result);
Console.WriteLine("SPOSOB ADAMA");
Console.WriteLine($"{empMax.Name} {empMax.Surname} Lat {empMax.Age} Zdobył {empMax.Result} punktów");