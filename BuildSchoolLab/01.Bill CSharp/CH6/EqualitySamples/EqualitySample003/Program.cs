using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualitySample003
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;
            // int 的  Equals 有多載，此處呼叫的是  int.Equals(int) 而非 object.Equals(object)
            Console.WriteLine("i.Equals(j) is " + i.Equals(j));
            MyRectangle r1 = new MyRectangle { Width = 5, Height = 5 };
            MyRectangle r2 = new MyRectangle { Width = 5, Height = 5 };
            object o = r2;
            MyRectangle r3 = r2;
            Console.WriteLine("r1.Equals(r2) is " + r1.Equals(r2));
            Console.WriteLine("r1.Equals(o) is " + r1.Equals(o));
            Console.WriteLine("r2.Equals(r3) is " + r2.Equals(r3));


            Console.WriteLine(object.Equals(r1, r2));
            Console.ReadLine();
        }
    }
}
