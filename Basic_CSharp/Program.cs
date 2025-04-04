﻿/*
// implicit conversion
int myInput = 1348912084;
double myDouble = myInput;

long myLong = myInput;

myLong = 39102948140145320;

float myFloat = 123.123f;
myDouble = myFloat;
*/

/*35.Fixing some more bugs
//datatype variableName = initial value;
double myNumber = 0;
double myNumber2 = 0;
Console.WriteLine("Enter a whole number!");

string firstNumber = Console.ReadLine();
myNumber = double.Parse(firstNumber);

Console.WriteLine("Enter a whole number!");
firstNumber = Console.ReadLine(); 
myNumber2 = double.Parse(firstNumber);

double sum = Math.Round((myNumber + myNumber2), 2);

// we are adding to strings together and writing them onto the console
Console.WriteLine($"The result of {myNumber} and {myNumber2} is {sum}" );
*/

/* My solution 🧠
Console.WriteLine("Enter the first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {firstNumber + secondNumber}");
*/

/*
// 26 Variable Definition, Initialization and Assigning
// defining or setting up a variable
string petsName;

// initialize variable
petsName = "Milo";
Console.WriteLine($"my pet is {petsName}");
petsName = "Barky";
Console.WriteLine($"my pet is {petsName}");
*/

/*
//23. Overview of Data Types
// Referency Type
string myName = "Manhj";

// Value Type
int myAge = 35;
double pi = 3.14;

byte age = 255;

short linkInConnections = 32550;

long phoneNumber = 017547723991;

float pi2 = 3.14f;
*/

/*
//Understand User Input and the Data Type String
//Prints out whatever is in side of ()
Console.WriteLine("What is your name?");
Console.Beep();
// Variable with the name "nameUser" and the data type "string"
// strings are used for text
string nameUser = Console.ReadLine() ?? "";
Console.WriteLine("You entered " + nameUser);
// takes the user input and stores it
*/


/*
//15.  Using variables - String
Console.WriteLine("Hello, World");
//declare a (string) variable
string myName;
// assign a value to the myFriendsName variable 
myName = "manhj";
// use/access the variable
Console.WriteLine(myName);
myName = "Manh";
Console.WriteLine(myName);
//declare a variable and assign a value to it.
string myName2 = "Manhj";
*/

Console.ReadKey();