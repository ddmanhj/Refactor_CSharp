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
		// Constructor
		public Car(string model, string brand) {
			_model = model;
            Console.WriteLine($"A {brand} of the model {_model} has been created");
        }
	}
}
