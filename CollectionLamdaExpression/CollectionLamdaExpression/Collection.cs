using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLamdaExpression
{
    internal class Collection
    { 
            public  void Main(String[] args)
            {

                // Creating a List of integers
                List<int> mylist = new List<int>();

                // adding items in mylist
                for (int j = 5; j < 10; j++)
                {
                    mylist.Add(j * 3);
                }

                // Displaying items of mylist
                // by using foreach loop
                foreach (int items in mylist)
                {
                    Console.WriteLine(items);
                }
            }
    }
}
