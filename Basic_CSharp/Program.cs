// More String Manipulation with String Formatting
int num = 10;
double price = 19.95;
string name = "Manhj";

// String Interpolation
Console.WriteLine($"The number is {num}");
// String concatination
Console.WriteLine("The number is " + num);
// String formatting
Console.WriteLine("The number is {0}, and the price is {1}", num, price);

/*
// Debug
int num1 = 14;
Console.WriteLine("Please enter a whole number!");
int num2 = int.Parse(Console.ReadLine());

// Conditional
Console.WriteLine("Age is " + num1);

Console.WriteLine("Addition num1 + num2 = " + num1 + num2);
// Order of Evaluation

Console.WriteLine("Subtraction num1 - num2 = " + (num1 - num2));

Console.WriteLine("Division num1 / num2 = " + num1 / num2);
*/

/*
// Operators, order of Evaluation and some math basics
int num1 = 5;
int num2 = 13;
//Concatination
Console.WriteLine("Age is " + num1);

Console.WriteLine("Addition num1 + num2 = " + num1 + num2);
// Order of Evaluation
Console.WriteLine("Subtraction num1 - num2 = " + (num1 - num2));
// "Subtraction num1 - num2 = 5" - 13
// ==> Sử dụng () để phân biệt lúc nào cộng number lúc nào cộng string
Console.WriteLine("Multiplication num1 * num2 = " + num1 * num2);
Console.WriteLine("Division num1 / num2 = " + (num1 / num2));
*/

/*
// explicitely typed variable (Khai báo ngầm định)
var myFavoriteGenre = "LitRPGs";
var myFavoriteNumber = 13;
var yourFavoriteNumber = 14;
var ourNumbersCombined = myFavoriteNumber = yourFavoriteNumber;

// Implicitly Typed Variables (Khai báo tường minh)
// Referency Type
string myName = "manhj";
*/


/*
// Conversion Helpers Parse and Convert
string numberString = "123";
int result = int.Parse(numberString);

string myBoolString = "true";
bool myBool = Convert.ToBoolean(myBoolString);
Console.WriteLine("myBool is " + myBool);
*/

/*
// Explicit conversion
int myInput = 1348912084;		myBool	false	bool

double myDouble = myInput;

long myLong = myInput;
myLong = 1323450;

// explicit conversion
int myInt2 = (int)myLong;
Console.WriteLine(myInt2);

float myFloat = 123.123f;
myDouble = myFloat;
*/

/*
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