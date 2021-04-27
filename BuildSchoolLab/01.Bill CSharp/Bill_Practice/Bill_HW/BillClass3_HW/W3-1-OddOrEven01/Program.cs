using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3_1_OddOrEven01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串以逗號分隔的字串：");
            //解1(或可全用var宣告)
            string step1 = Console.ReadLine();
            string[] step2 = step1.Split(',');
            IEnumerable<string> step3 = step2.Reverse();
            string step4 = string.Join(",", step3);
            Console.WriteLine($"{step4}");
            Console.ReadLine();

            //解2
            //Console.WriteLine($"結果： {string.Join(",", Console.ReadLine().Split(',').Reverse())}");
            //Console.ReadLine();
        }
    }
}
