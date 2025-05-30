namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Car class
            // Creating an instace of the Class Car
            Car audi = new Car("A3", "Audi", false);
            Car bmw = new Car("i7", "BMW", true);

            Console.WriteLine("Please enter the Brand name");

            // "SETING BRAND"
            audi.Brand = Console.ReadLine();

            // "GETTING BRAND"
            Console.WriteLine("Brand is: " + audi.Brand);

            Console.ReadKey();
        }
    }
}
