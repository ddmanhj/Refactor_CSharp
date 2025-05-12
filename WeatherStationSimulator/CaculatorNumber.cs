using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationSimulator.CalculatorNumber
{
    internal class NumberVar
    {


        public void SetNum()
        {
            int myInt = 5;
            //double myDouble = 8.1;

            double myDoubleResult = myInt / 8.0 + 5/3;
            Console.WriteLine(myDoubleResult);
            //int myIntResult = (int) (myInt / myDouble);
        }
    }
}
