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
        //Property
        public string Model { get => _model; set => _model = value; }
        private string _brand = "";
        public string Brand { get => _brand; set => _brand = value; }

		// Constructor
		public Car(string model, string brand) {
            Brand = brand;
            Model = model;
            Console.WriteLine($"A {Brand} of the model {Model} has been created");
        }

      
    }
}
