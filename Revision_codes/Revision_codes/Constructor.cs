using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_codes
{
    internal class ConstructorCar
    {
        public string model;  // Create a field

        // Create a class constructor for the ConstructorCar class
        public ConstructorCar()
        {
            model = "Mustang"; // Set the initial value for model
        }

        public void Main(string[] args)
        {
            ConstructorCar Ford = new ConstructorCar();  // Create an object of the ConstructorCar Class (this will call the constructor)
            Console.WriteLine(Ford.model);  // Print the value of model
        }
    }
}
