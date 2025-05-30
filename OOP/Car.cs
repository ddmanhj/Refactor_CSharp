using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // It's a internal, which means that it can only be accessed within the same assembly.

    internal class Car
    {
        // member variable
        // private hides the variable from other classes
        private string _model = "";
        private string _brand = "";
        private bool _isLuxury;
        //Property
        public string Model { get => _model; set => _model = value; }

        public string Brand
        {
            get => _brand;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING!");
                    _brand = "Unknown"; // Default value if nothing is entered
                }
                else
                {
                    _brand = value;
                }
            }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        // Constructor
        public Car(string model, string brand, bool isLuxury)
        {
            Brand = brand;
            Model = model;
            _isLuxury = isLuxury;
            Console.WriteLine($"A {Brand} of the model {Model} has been created");
        }
    }
}
