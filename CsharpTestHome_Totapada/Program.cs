using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestHome_Totapada
{
    class Program
    {
        static void Main(string[] args)
        {
            bool myfirstboolean = 3 + 2 == 5;
            Console.WriteLine(myfirstboolean.ToString());
            bool mysecondboolean = 3 + 2 > 5;
            Console.WriteLine(mysecondboolean.ToString());
            bool bothAreTrue = myfirstboolean && mysecondboolean;
            Console.WriteLine("both are True Evaluates " + bothAreTrue);
            bool oneIStrue = myfirstboolean || mysecondboolean;
            Console.WriteLine("oneIS true evaluates {0} because one expression is true", oneIStrue);



        }

    }
}
