using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;
            Console.WriteLine("i.Equals(j) is "+ $"{ i.Equals(j) }");
            MyRectangle r1 = new MyRectangle { Width = 5, Height = 5 };
            MyRectangle r2 = new MyRectangle { Width = 5, Height = 5 };
            MyRectangle r3 = r2;
            Console.WriteLine($"object.Equals(r1,r2) is { r1.Equals(r2) }");
            Console.WriteLine($"object.Equals(r2,r3) is { r2.Equals(r3) }");
            Console.ReadLine();

        }
    }
}
