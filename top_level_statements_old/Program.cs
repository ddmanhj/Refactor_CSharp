namespace OldStyle
{
    internal class Program
    {
        // Field (or instance variable)
        static int myResult;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, I'll add 10 to it!");
            bool isNumber = int.TryParse(Console.ReadLine(), out int num1);
            if (isNumber)
            {
                myResult = AddTwoValues(num1, 10);

                Console.WriteLine("The result is: " + myResult);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static int AddTwoValues(int value1, int value2)
        {
            myResult = value1 + value2;
            return myResult;
        }

        static int SubtractTwoValues(int value1, int value2)
        {
            myResult = value1 - value2;
            return myResult;
        }

    }
}
