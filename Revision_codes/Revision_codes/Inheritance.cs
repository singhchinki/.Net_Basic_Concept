using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_codes
{
    internal class Inheritance  // base class (parent)
    {    
            public string brand = "Ford";  // Vehicle field
            public void honk()             // Vehicle method 
            {
                Console.WriteLine("Tuut, tuut!");
            }
        

        class Car : Inheritance  // derived class (child)
        {
            public string modelName = "Mustang";  // Car field
        }
            public void Main(string[] args)
            {
                // Create a myCar object
                Car myCar = new Car();

                // Call the honk() method (From the Inheritance class) on the myCar object
                myCar.honk();

                // Display the value of the brand field (from the Inheritance class) and the value of the modelName from the Car class
                Console.WriteLine(myCar.brand + " " + myCar.modelName);
            }
        }
    }

