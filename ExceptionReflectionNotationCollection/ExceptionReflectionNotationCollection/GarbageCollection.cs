using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionReflectionNotationCollection
{
    public class GarbageCollection
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));

            GarbageCollection obj = new GarbageCollection();

            Console.WriteLine("The generation number of object obj is: "
                                               + GC.GetGeneration(obj));

            Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
        }
    }
}     