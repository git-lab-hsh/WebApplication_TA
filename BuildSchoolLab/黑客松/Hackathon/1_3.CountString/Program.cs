using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3.CountString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個有意義的英文敘述字串:");
            var step1 =Console.ReadLine();
            var step2 = step1.ToLower().Split(' ').GroupBy(x =>x).Select(x=> $"{x.Key}:{x.Count()}");
            var step3 = string.Join("\n",step2);
            Console.WriteLine(step3);
            Console.ReadLine();
        }
    }
}
