using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public partial class Excersice1
    {
        public void Excersice1Program()
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            string rocketString = "   /\\  \n   ||  \n   ||  \n   ||  \n   ||  \n  /  \\";
            string rocketFireString = "   \u15D1\u15D1\n";
            string rocketAirString = "\n";
            int rocketHeight = 10;

            for (int i = 0; i < rocketHeight; i++)
            {
                Console.Clear();
                for (int stepsAbove = 0; stepsAbove <= i; stepsAbove++)
                {
                    Console.WriteLine(rocketAirString);
                }
                Console.WriteLine(rocketString);
                for (int stepsBelow = (rocketHeight - i); stepsBelow >= 2; stepsBelow--)
                {
                    Console.WriteLine(rocketFireString);
                }
                Console.WriteLine("-^^--^^----------------");
                Thread.Sleep(500);
            }
            Console.WriteLine("\r\nThe rocket has landed. Woohoo! Another successful landing!");

            Console.ReadLine();
        }
    }
}
