using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Constructor
        public Customer()
        {
            Name = "New Customer";
            Address = "Unknown";
            ContactNumber = "NA";
        }

        // Custom Constructor
        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        } 
    }
}
