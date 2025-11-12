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

        //
        // private string _model = "";
        
        private string _brand = "";
        //private bool _isLuxury;
        //Property
        //public string Model { get => _model; set => _model = value; }
        public string Model { get; set; }


        public string Brand
        {
            get
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Car";
                }

                else
                {
                    return _brand;
                }
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Brand name cannot be empty. Setting to 'Unknown'.");
                    _brand = "Unknown";
                }
                else
                {
                    _brand = value;
                }
            }
        }
        
        public bool IsLuxury { get; set; }

        // Cách viết property này thường nên rút gọn thành { get; set; }, bởi vì cách này chỉ nên dùng khi cần validate hay làm logic khác như Brand
        // Còn nếu chỉ đọc và set lại giá trị thì dùng { get; set; } cho ngắn gọn
        //public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        // Constructor
        public Car(string model, string brand, bool isLuxury)
        {
            Brand = brand;
            Model = model;
            IsLuxury = isLuxury;
            Console.WriteLine($"A {Brand} of the model {Model} has been created");
        }
    }
}
