using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace DLLSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRectangle rect = new MyRectangle();
            rect.Witdh = 10;
            rect.Height = 10;
            Console.WriteLine("面積為 :" + rect.GetArea());
            Console.ReadLine();
        }
    }
}
