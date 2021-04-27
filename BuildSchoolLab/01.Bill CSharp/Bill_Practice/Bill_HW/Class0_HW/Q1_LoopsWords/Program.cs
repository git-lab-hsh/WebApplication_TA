using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_LoopsWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一段文字:");
            string x = Console.ReadLine();
            string y = "";
            for (int i = x.Length - 1; i >= 0; i--)
            {
                y += x[i];
            }
            // Console.WriteLine(y);
            if (x == y)
            { Console.WriteLine("是"); }
            else
            { Console.WriteLine("不是"); }

            Console.ReadLine();
        }
    }
}
