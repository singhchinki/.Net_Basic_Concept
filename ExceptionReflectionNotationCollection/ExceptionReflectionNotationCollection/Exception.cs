using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionReflectionNotationCollection
{
    class Exception
        {
            public void calculatedifference()
            {
                int difference = 0;
                int[] number = new int[5] { 1, 2, 3, 4, 5 };
                try
                {
                    for (int init = 1; init <= 5; init++)
                    {
                        difference = difference - number[init];
                    }
                    Console.WriteLine("The difference of the array is:" + difference);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        
            public void Main(string[] args)
            {
                Exception obj = new Exception();
                obj.calculatedifference();
                Console.ReadLine();
            }
        
    }
}
