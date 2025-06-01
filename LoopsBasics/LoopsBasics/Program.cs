// See https://aka.ms/new-console-template for more information

// while loop is a pre-test loop

//Random random = new Random();
//int randomNumber = random.Next(1, 100);
//int userGuess = 0;
//int counter = 0;
//Console.WriteLine("Guess the number I am thinking of between 1 and 100: ");

//while(userGuess !=randomNumber)
//{
//    counter++;
//    Console.WriteLine("Enter you guess: ");
//    userGuess = int.Parse(Console.ReadLine());
//    if (userGuess < randomNumber)
//    {
//        Console.WriteLine("To Low! Try Again!");
//    }else if (userGuess > randomNumber){
//        Console.WriteLine("To High! Try Again!");
//    }
//    else
//    {
//        Console.WriteLine($"You got it!Congrats! and it is {randomNumber}.It took you {counter} trials to guess.");
//    }
//}
//Console.ReadKey();

int currentScore;
int sum=0;
int counter = 0;

// do while loop is a post-test loop
do
{
    Console.WriteLine("Enter your student scores for each subject: ");
    currentScore = int.Parse(Console.ReadLine());
    sum = sum + currentScore;
    counter++;
} while (counter <=5);

int average = sum / counter;
Console.WriteLine($"The average score of student is {average}");
Console.ReadKey();