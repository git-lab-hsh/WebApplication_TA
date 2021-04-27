using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualitySample004
{
    class Program
    {
        private static void Main(string[] args)
        {
            MyRectangle r1 = new MyRectangle { Width = 5, Height = 5 };
            MyRectangle r2 = new MyRectangle { Width = 5, Height = 5 };
            object o = r2;
            MyRectangle r3 = r2;
            Console.WriteLine("r1.Equals(r2) is " + r1.Equals(r2));
            Console.WriteLine("r1.Equals(o) is " + r1.Equals(o));
            Console.WriteLine("r2.Equals(r3) is " + r2.Equals(r3));

            Console.ReadLine();
        }
    }
}
