using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_codes
{
    internal class Car //class name with specifier(internal)
    {
        
            string color = "red"; // class member

            public void Main(string[] args) // method
            {
                Car myObj = new Car();
                Console.WriteLine(myObj.color);
            }
        
    }
}
