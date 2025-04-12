using Loops;

Random random = new Random();
int secretNumber = random.Next(1, 101);
int userGuess = 0;
int counter = 1;

while (userGuess != secretNumber)
{
    Console.WriteLine("Enter your guess");
    userGuess = int.Parse(Console.ReadLine());
    if (userGuess < secretNumber)
    {
        Console.WriteLine("Too low! Try again.");
        counter++;
    }
    else if (userGuess > secretNumber)
    {
        Console.WriteLine("Too high! Try again.");
        counter++;
    }
    else
    {
        Console.WriteLine("Congratulations! You guessed the number! It took you " + counter);
    }
}

/*
// The While Loop
Console.WriteLine("Enter go or stay");
string userChoice = Console.ReadLine();

while (userChoice == "go")
{
    Console.WriteLine("Go for a mile");
    Console.WriteLine("Wanna keep going? Enter go");
    userChoice = Console.ReadLine();
}
Console.WriteLine("Finally you are staying");

int counter = 0;
while (counter < 10)
{
    Console.WriteLine(counter);
    counter++;
}
*/

/*
// in strings \ is an "Escape Character"
// \n stands for "new line"
// \r - carriage return


var Excersice1 = new Excersice1();
Excersice1.Excersice1Program();

string myString = "Hi \r\nHi";

for (int counter = 10; counter >= 0; counter--)
{
    Console.WriteLine("Counter is " + counter);
    Console.WriteLine(myString);
    Thread.Sleep(600); // Sleep for 1 second
}
*/

Console.ReadKey();