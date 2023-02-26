/*
//Tablice
int[] points= new int[5];
string[] daysOfWeeks= new string[7];

daysOfWeeks[0] = "poniedzialek";
daysOfWeeks[1] = "wtorek";
daysOfWeeks[2] = "sroda";
daysOfWeeks[3] = "czwartek";
daysOfWeeks[4] = "piatek";
daysOfWeeks[5] = "sobota";
daysOfWeeks[6] = "niedziela";

//inny sposob na tablice
string[] daysOfWeeks2= {"pon","wt"};
Console.WriteLine(daysOfWeeks2[1]);

for(int i = 0; i < daysOfWeeks.Length; i++)
{
    Console.WriteLine(daysOfWeeks[i]);
}
Console.WriteLine(" ");
foreach(var day in daysOfWeeks)
{
    Console.WriteLine(day);
}

//Listy (tablice na sterydach)
List<string> daysOfWeek3= new List<string>();
foreach(string day in daysOfWeeks)
{
    daysOfWeek3.Add(day);
} 

for(int i = 0;i < daysOfWeek3.Count; i++)
{
    Console.WriteLine(daysOfWeek3[i]);
}*/

int number = 1564161;
string numberInString= number.ToString();
char[] letters = numberInString.ToArray();

char[] numbersToCheck = { '0', '1', '2', '3','4','5','6','7','8','9' };
int[] result= {0,0,0,0,0,0,0,0,0,0};

for(int i = 0; i < 10; i++)
{
    for (int j = 0; j < letters.Length; j++) 
        if (numbersToCheck[i] == letters[j])
        {
            result[i]++;
        }
}

for (int i = 0;i<10; i++)
{
    Console.WriteLine(i+" => " + result[i]);
}