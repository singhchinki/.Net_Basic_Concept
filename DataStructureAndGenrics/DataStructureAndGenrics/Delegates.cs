using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate T NumberChanger<T>(T n);

namespace DataStructureAndGenrics
{
   internal class Delegate
        {
             int num = 10;
            public  int AddNum(int p)
            {
                num += p;
                return num;
            }

            public  int MultNum(int q)
            {
                num *= q;
                return num;
            }
            public  int getNum()
            {
                return num;
            }

            public void Main(string[] args)
            {
                NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
                NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);
                nc1(25);
                Console.WriteLine("Value of Num: {0}", getNum());
                nc2(5);
                Console.WriteLine("Value of Num: {0}", getNum());
                Console.ReadKey();
            }
   }
    
}
