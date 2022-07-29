using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndGenrics
{
    internal class Queues
    {
		public void Main()
		{

			Queue myQueue = new Queue();

			myQueue.Enqueue("one");

			Console.Write("Total number of elements in the Queue are : ");

			Console.WriteLine(myQueue.Count);

			myQueue.Enqueue("two");

			Console.Write("Total number of elements in the Queue are : ");

			Console.WriteLine(myQueue.Count);

			myQueue.Enqueue("three");

			Console.Write("Total number of elements in the Queue are : ");

			Console.WriteLine(myQueue.Count);

			myQueue.Enqueue("four");

			
			Console.Write("Total number of elements in the Queue are : ");

			Console.WriteLine(myQueue.Count);

			myQueue.Enqueue("five");

			
			Console.Write("Total number of elements in the Queue are : ");

			Console.WriteLine(myQueue.Count);

			myQueue.Enqueue("six");

			Console.Write("Total number of elements in the Queue are : ");

			Console.WriteLine(myQueue.Count);
		}
	}

}

