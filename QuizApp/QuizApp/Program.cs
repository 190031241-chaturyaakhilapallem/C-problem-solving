// See https://aka.ms/new-console-template for more information
string question1 = "What is the capital of India?";
string answer1 = "New Delhi";

string question2 = "what is 2+2?";
string answer2 = "4";

string question3 = "what color do you get by mixing red and blue?";
string answer3 = "purple";

int score = 0;

Console.WriteLine("question1");
string userAnswer1 = Console.ReadLine();
if (userAnswer1.Trim().ToLower() == answer1.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Not Correct!The correct answer is " + answer1);

}

Console.WriteLine("question2");
string userAnswer2 = Console.ReadLine();
if (userAnswer2.Trim().ToLower() == answer2.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Not Correct!The correct answer is " + answer2);

}

Console.WriteLine("question3");
string userAnswer3 = Console.ReadLine();
if (userAnswer3.Trim().ToLower() == answer3.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Not Correct!The correct answer is " + answer3);

}

Console.WriteLine($"Congratulations!! Quiz is completed!! Your final score is: {score}/3");

if (score == 3)
{
    Console.WriteLine("Excellent! You got all the answers right.");
}
else if (score>0)
{
    Console.WriteLine("Good job! But try again to get a full score.");
}
else
{
    Console.WriteLine("Try again please to get some answers right next time...");
}
    Console.ReadKey();