
var name = "Kuba";
char sex = 'm';
int age = 26;

if (age <= 30 && sex == 'm')
{
    Console.WriteLine("Mezczyzna poniezj 30 lat");
}

Console.WriteLine($"{name}, lat {age}");

if(age > 18)
{
    Console.WriteLine("Pelnoletni mezczyzna");
}
else
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}