// See https://aka.ms/new-console-template for more information

double CalculateAverage(double[] temperature)
{
    double sumCalculateAverage = 0;
    for (int i = 0; i < temperature.Length; i++)
    { 
        sumCalculateAverage += temperature[i];
    }
    return Math.Round(sumCalculateAverage / temperature.Length, 1);
}

void PrintAverage(double[] temperature) {
    Console.WriteLine($"The average temperature is: {CalculateAverage(temperature)}");
}

PrintAverage([3, 26, 24.4, 27, 25]);
/*
double num1 = 0;
double num2 = 0;
Console.WriteLine("Enter a number 1");
string Enternum1 = Console.ReadLine();
bool isNumber1 = double.TryParse(Enternum1, out num1);
Console.WriteLine("Enter a number 2");
string Enternum2 = Console.ReadLine();
bool isNumber2 = double.TryParse(Enternum2, out num2);
Console.WriteLine("Choose an arithmetic operation (+, - , * ,/)");
string operation = Console.ReadLine();

if (isNumber1 || isNumber2)
{
    switch (operation)
    {
        case "+":
            Console.WriteLine($"The result is: {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"The result is: {num1 - num2}");
            break;
        case "*":
            Console.WriteLine($"The result is: {num1 * num2}");
            break;
        case "/":
            if (num2 != 0)
            {
                Console.WriteLine($"The result is: {num1 / num2}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            break;
        default:
            Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
            break;
    }

}
else
{
    Console.WriteLine("You entered a string, not a number");
}

/*



/*
// Creating an instance of the Random Class
Random random = new Random();
// This will give us a random number between 1 and 10
int randomNumber = random.Next(1, 11);
Console.WriteLine("Give me a number");
string inputString = Console.ReadLine();
int num1 = 0;

bool isNumber = int.TryParse(inputString, out num1);

if (isNumber)
{
    if (num1 == randomNumber)
    {
        Console.WriteLine("You guessed right!");
    }
    else
    {
        Console.WriteLine("You guessed wrong, try again!");
    }
}
else
{
    Console.WriteLine("You entered a string, not a number");
}
*/

/*
//Try parse to safely convert
Console.WriteLine("Give me a number");
string inputString = Console.ReadLine();
int num1 = 0;

bool isNumber = int.TryParse(inputString, out num1);
if (isNumber)
{
    Console.WriteLine("Well done, you entered a number");
}
else
{
    Console.WriteLine("You entered a string, not a number");
}
num1++;
Console.WriteLine("User entered number +1 " + num1);
*/

/*
int num = 0;

Console.WriteLine($"Num is {num}"); // 0
// incrementing of int
num++;
Console.WriteLine($"Num is {num}"); // 1

// pre-incrementing
Console.WriteLine("Num is {0}", ++num); // 2
Console.WriteLine("Num is {0}", num++); // 2
Console.WriteLine("Num is {0}", num); // 3
*/

//num--;
//Console.WriteLine("Num is {0}", num);

/*
string question1 = "What is the capital of Germany";
string answer1 = "Berlin";

string question2 = "What is 2+2";
string answer2 = "4";

string question3 = "What color do you get by mixing blue and yellow";
string answer3 = "green";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
string userAnswer2 = Console.ReadLine();
string userAnswer3 = Console.ReadLine();
if (userAnswer1.Trim().ToLower() == answer1.ToLower())
{
    Console.WriteLine("Correct!");
    score += 1;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer1);
}

if (userAnswer2.Trim().ToLower() == answer2.ToLower())
{
    Console.WriteLine("Correct!");
    score += 1;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer1);
}

if (userAnswer3.Trim().Trim().ToLower() == answer3.ToLower())
{
    Console.WriteLine("Correct!");
    score += 1;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer1);
}

Console.WriteLine($"Quiz completed! Your final score is: {score}/3");
if (score == 3)
{
    Console.WriteLine("Excellent! You got all the answers right!");
}
else
{
    Console.WriteLine("Try again and see if you can get some answers right next time!");
}
*/

/*
int day = 3;
string dayName;
switch (day)
{
    case 2:
        dayName = "Monday";
        break;
    case 3:
        dayName = "Tuesday";
        break;
    case 4:
        dayName = "Wednesday";
        break;
    case 5:
        dayName = "Thursday";
        break;
    case 6:
        dayName = "Friday";
        break;
    case 7:
        dayName = "Saturday";
        break;
    case 8:
        dayName = "Sunday";
        break;
    default:
        dayName = "Invalid Day!";
        break;
}

Console.WriteLine($"day {day} is: {dayName}");
*/

/*
Console.WriteLine("How old are you? Write a whole number");
int age = Convert.ToInt16(Console.ReadLine());
bool isWithParents;
if (age >= 18)
{
    Console.WriteLine("Go party in the club!");
}
else if (age > 13)
{
    Console.WriteLine("Are you with your parents? Answer with Y or N");
    string isWithParentsString = Console.ReadLine();
    if (isWithParentsString == "y")
    {
        Console.WriteLine("Go party in the club with your parents!");

    }
    else
    {
        Console.WriteLine("No party for you today!");
    }
}
else
{
    Console.WriteLine("Go party in school!");
}
*/

/*
int num1 = 0;
int num2 = 0;
int age = 0;
string address = "";


bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;


Console.WriteLine("Please enter a whole number");
if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal!");
    age = int.Parse(Console.ReadLine());
    if (age >= 18)
    {
        Console.WriteLine("Please enter your address, " + "so that we can send you the price!");
        address = Console.ReadLine();

    }
    else
    {
        Console.WriteLine("Sorry, you can't get your price due to your age!");
    }
}
else
{
    Console.WriteLine("Numbers aren't equal");
}
*/

/*
// Relational Operators < <= > >= == !=
Console.WriteLine("How old are you?");
int ageUser = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Are you going with your parents?");
bool isWithParents = Convert.ToBoolean(Console.ReadLine());

if (ageUser >= 13 && isWithParents)
{
    Console.WriteLine("Go party in the club with your parents!");
}
else if (ageUser > 18)
{
    Console.WriteLine("Go party in the club!");

}
else
{
    Console.WriteLine("Go party in school!");
}
*/

/*
bool isRainy = true;
bool hasUmbrella = true;

// Logical Operators
// AND &&
// OR ||
// NOT !

// Variants of OR statements
// true && true => True
// true && false => False
// false && true => False
// false && false => False

if (isRainy && hasUmbrella)
{
    Console.WriteLine("I'M not getting wet!");
}
Console.WriteLine("Ay OK!");
*/

Console.ReadKey();