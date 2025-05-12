using WeatherStationSimulator.CalculatorNumber;

namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NumberVar calculator2Number = new NumberVar();
            //calculator2Number.SetNum();
            Console.WriteLine("Enter the number of days to simulate: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int days);
            if (!isNumber)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            double[] temperature = new double[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }
            Console.WriteLine($"Average Temperature is: {CalculateAverage(temperature)}");
            Console.WriteLine($"The max temp was: {temperature.Max()}");
            Console.WriteLine($"The min temp was: {temperature.Min()}");
            Console.WriteLine($"The min temp with my function was: {MinTemperature(temperature)}");
            Console.WriteLine($"Most common condition is: {MostCommonCondition(weatherConditions)} ");
            Console.ReadKey();
        }

        static string MostCommonCondition(string[] conditions)
        { // 1st iiteration "Sunny"
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++) {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++) {
                    if (conditions[j] == conditions[i])
                    {

                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }

            return mostCommon;
        }

        static double CalculateAverage(double[] temperature)
        {
            double sum = 0;
            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }

            double average = sum / temperature.Length;
            return Math.Round(average, 1);
        }

        // Find number smallest in array
        static double MinTemperature(double[] temperature)
        {
            double min = temperature[0];
            foreach (double temp in temperature)
            {
                if (temp < min)
                {
                    min = temp;
                }
            }
            return min;
        }

        
    }
}
