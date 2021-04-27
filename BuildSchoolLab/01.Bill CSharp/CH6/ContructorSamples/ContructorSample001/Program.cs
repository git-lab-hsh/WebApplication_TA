using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructorSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass o1 = new BaseClass();
            Display("o1", o1.X);

            BaseClass o2 = new BaseClass(99);
            Display("o2", o2.X);          


            Console.ReadLine();
        }

        static void Display(string name, int value)
        {
            Console.WriteLine($"{name} 的 X 是 {value}");
        }
    }
}
