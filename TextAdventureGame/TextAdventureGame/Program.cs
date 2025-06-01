// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Welcome to the Adventure Game!!");
Console.WriteLine("Enter your Game Character's name: ");
string characterName = Console.ReadLine();
Console.WriteLine("Choose your Character class: (Warrior, Wizard, Archer)");
string characterClass = Console.ReadLine();
Console.WriteLine($"You {characterName} of character class {characterClass} have found yourself at a dark forest!!");
Console.WriteLine("Do you want to enter the forest or camp outside?");
string choice1 = Console.ReadLine();
if (choice1.ToLower() == "enter")
{
    Console.WriteLine("You have bravely entered the forest!!");
}
else
{
    Console.WriteLine("you decided to camp out of the forest and wait for the morning light!!");
}

bool gameContinues = true;

if (gameContinues)
{
    Console.WriteLine("you have come to an intersection at the road, go left or right?");
    string direction = Console.ReadLine();
    if ( direction.ToLower() == "left")
    {
        Console.WriteLine("You have found a treasure chest!!");
        gameContinues = false;
    }
    else
    {
        Console.WriteLine("You have encountered a wild monster!! Run!!");
        Console.WriteLine("Either Fight it or Run from it ( fight/ run)");
        string fightChoice = Console.ReadLine();
        if (fightChoice.ToLower() == "fight")
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            if (randomNumber> 5)
            {
                Console.WriteLine("You beat the monster!");
                if (randomNumber>8)
                {
                    Console.WriteLine("the beast dropped a treasure");
                }
            }
            else
            {
                Console.WriteLine("you are dead!");
                Console.WriteLine(" the beat brutally killed you!");
                gameContinues = false;
            }
        }


    }

}

Console.ReadKey();
