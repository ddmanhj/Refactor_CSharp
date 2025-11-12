namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Create an object of the Car class
            // Creating an instace of the Class Car
            Car audi = new Car("A3", "Audi", false);
            Car bmw = new Car("i7", "BMW", true);

            Console.WriteLine("Please enter the Brand name");

            // "SETING BRAND"
            audi.Brand = Console.ReadLine();

            // "GETTING BRAND"
            Console.WriteLine("Brand is: " + audi.Brand);
            */

            //Customer earl = new Customer("Earl", "123 Main St", "09853584932");
            Customer earl = new Customer("Earl");
            Customer frankTheTank  = new Customer("farnkTheTank", "MainStreet 1", "09857438192");
            Console.WriteLine("Name of Customer is " + earl.Name);
            Console.ReadKey();
        }
    }
}
