// See https://aka.ms/new-console-template for more information

int num1 = 0;
int num2 = 0;


bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;


Console.WriteLine("Please enter a whole number");
if (num1 == int.Parse(Console.ReadLine()))
{
	Console.WriteLine("Numbers are equal!");
	int age = int.Parse(Console.ReadLine());
	if (age >= 18)
	{
        Console.WriteLine("Please enter your address, " + "so that we can send you the price!");
        string address = Console.ReadLine();
		
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