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
              //---------------------------
            Console.WriteLine("Please enter the Brand name");
              //---------------------------
            // "SETING BRAND"
            audi.Brand = Console.ReadLine();
              //---------------------------
            // "GETTING BRAND"
            Console.WriteLine("Brand is: " + audi.Brand);
            */
            //---------------------------
            //Car myAudi = new Car("A3", "Audi", false);
            //myAudi.Drive();
            //---------------------------
            //Customer earl = new Customer("Earl", "123 Main St", "09853584932");
            //---------------------------
            Customer earl = new Customer("Earl");
            Customer frankTheTank = new Customer("farnkTheTank", "MainStreet 1", "09857438192");
            //Console.WriteLine("Name of Customer is " + earl.Name);
            // Default Customer with no Arguments given
            Customer myCustomer = new Customer();
            Console.WriteLine("Please enter the customers Name");
            myCustomer.Name = Console.ReadLine();
            Console.WriteLine("Details about customer: " +
                "" + myCustomer.Name);

            // -----------------------------------------------------------------------------------
            //Customer defaultCustomer = new Customer();
            //Console.WriteLine("Default Customer Name is " + defaultCustomer.Name);
            // -----------------------------------------------------------------------------------


            myCustomer.SetDetails("John Doe", "456 Elm St");


            Console.ReadKey();
        }
    }
}
