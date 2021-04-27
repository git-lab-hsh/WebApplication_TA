using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace ExDLLSample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRectangle rect = new MyRectangle();
            rect.Witdh = 5;
            rect.Height = 5;
            Console.WriteLine(rect.GetArea());
            Console.ReadLine();

            MyRectangle r1 = new MyRectangle();
            MyRectangle r2 = r1; 
        }
    }
}
