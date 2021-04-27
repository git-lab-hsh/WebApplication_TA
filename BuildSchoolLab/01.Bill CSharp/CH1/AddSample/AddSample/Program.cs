using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSample
{
    class Program
    {
        /// <summary>
        /// 學習使用 "移至定義" 的功能
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i1 = 5;
            int i2= 3;
            double d = 9.8;
            string s1 = "The";
            string s2 = "End";
            Console.WriteLine(i1 + i2);
            Console.WriteLine(i1 + d);
            Console.WriteLine(s1 + s2);
            Console.WriteLine(s1 + i1);
            Console.WriteLine(d + s2);
            Console.ReadLine();
        }
    }
}
