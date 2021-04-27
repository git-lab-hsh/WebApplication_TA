using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i= 10;
            if ( (i >= Class1.MIN )&& (i  <= Class1.MAX ))
            {
                Console.WriteLine("符合條件");
            }
            Console.ReadLine();
        }
    }
}
