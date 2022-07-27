using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_codes
{
    internal class Encapsulation
    {
            private string name; // field
            public string Name   // property
            {
                get { return name; }
                set { name = value; }
            }
        
            public void Main(string[] args)
            {
                Encapsulation myObj = new Encapsulation();
                myObj.Name = "Chinki";
                Console.WriteLine(myObj.Name);
            }
        
    }
}
