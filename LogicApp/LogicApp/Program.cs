// See https://aka.ms/new-console-template for more information

/*
Console.WriteLine("Please enter your age: ");
int Age = int. Parse(Console.ReadLine());

if (Age >= 18)
{
    Console.WriteLine("Go party in club!!");
}
else if (Age >= 13)
{
    Console.WriteLine("Are you here with your parents?: Answer with y or n");
    string isWithParentsString = Console.ReadLine();
    if ( isWithParentsString== "y")
    {
        Console.WriteLine("Go party in club with your parents!!");
    }
    else
    {
        Console.WriteLine("No parrty for you.");
    }
}
else
{
    Console.WriteLine("Don't go to party.");
}
*/

int month=5;
string monthName;

/*
if (month==1)
{
    monthName = "January";
}
else if (month == 2) {
    monthName = "February";
}
else if (month ==3)
{
    monthName = "March";
}
else
{
    monthName = "unknown";
}
*/


switch (month)
{
    case 1:
        monthName = "January";
        break;
    case 2:
        monthName = "February";
        break;
    case 3:
        monthName = "March";
        break;
    default:
        monthName = "unknown";
        break;

}

Console.ReadKey();