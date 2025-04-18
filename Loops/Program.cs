using Loops;

int[,] my2DArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

for (int i = 0; i < my2DArray.GetLength(0); i++) // Lấy số hàng của mảng
{
    int sum = 0;
    for (int j = 0; j < my2DArray.GetLength(1); j++) // Lấy số cột của mảng
    {
        sum += my2DArray[i, j]; // Cộng dồn các phần tử trong hàng i
    }
    Console.WriteLine(sum);
}

Console.ReadKey();

/*exercise
 */

/*
// ThreeDimensional Arrays
string[,,] simple3DArray =
{
    {
        {"000", "001"},
        {"010", "011"}
    },
    {
        {"100", "101"},
        {"110", "111"}
    },
    {
        {"200", "201"},
        {"210", "211"}
    }
};
Console.WriteLine(simple3DArray[0,1,0]);// 0 planes, 1 rows, 0 columns => 010

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
*/


/*
// TwoDimensional Arrays (Mảng 2 chiều)
int[,] array2DDeclaration = new int[3, 3];
// [0] [0] [0]
// [0] [0] [0]
// [0] [0] [0]

int[,,] array3DDeclaration = new int[3, 3, 3];

int[,] array2DInizilized = { { 1, 2 }, { 3, 4 } };
// [1] [2] // row 0
// [3] [4] // row 1
Console.WriteLine(array2DInizilized[0, 1]); // 2
Console.WriteLine("After = " + array2DInizilized[1, 0]); // After = 3
array2DInizilized[1, 0] = 5;
Console.WriteLine("Before = " + array2DInizilized[1, 0]); // Before = 5

string[,] tickTacToeField =
{
    {"O", "X", "X"},
    {"O", "O", "X"},
    {"X", "X", "O"}
};

Console.WriteLine(tickTacToeField[1,2]);
*/

/*
//Array part 2 
// declare an array and set the array element values
int[] myIntArray = { 1, 14, 16, 20, 25 };
string[] weekDays = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"];

Console.WriteLine("Length of weekdays Arrays is " + weekDays.Length);

for (int i = 0; i < weekDays.Length; i++)
{
    //Console.WriteLine("Weekday " + (i + 1) + " is " + weekDays[i]);
}

foreach (var day in weekDays)
{
    Console.WriteLine(day);
}
*/

/*
// Simple Array
int[] myIntArray = new int[5];

myIntArray[0] = 1;
myIntArray[1] = 14;
myIntArray[2] = 16;
myIntArray[3] = 20;
myIntArray[4] = 25;

// Indexs   [0][1][2][3][4]
// Content  [1][14][16][20][25]
*/

/*
// break and continue
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 3)
    {
        continue; // Bỏ qua đoạn code này và tiếp tục vòng lặp
        Console.WriteLine("I've had enough!");
        // break; // Thoát khỏi vòng lặp ngay lập tức

    }

    Console.WriteLine("Only if not continued");
}
*/

/*
// Do while Loop
int currentScore;
int sum = 0;
int counter = 0;
// do-while loop is a  post-test loop

do
{
    Console.WriteLine("Enter your students score. Enter -1 to finish!");
    currentScore = int.Parse(Console.ReadLine());
    if (currentScore != -1)
    {
        sum = sum + currentScore;
        counter++;
    }


} while (currentScore != -1);

int average = sum / counter;
Console.WriteLine("The average is: " + average);
*/

//var textAdventureGame = new TextAdventureGame();
//textAdventureGame.TextAdventureGameProgram();

/*
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
*/

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