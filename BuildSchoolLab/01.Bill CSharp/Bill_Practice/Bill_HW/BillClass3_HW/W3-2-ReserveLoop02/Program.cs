using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3_2_ReserveLoop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數數字：");
            //可用var宣告
            string step1 = Console.ReadLine();
            int step2 = int.Parse(step1);
            IEnumerable<int> step3 = Enumerable.Range(1, step2);
            IEnumerable<int> step4 = step3.Reverse();
            IEnumerable<string> step5 = step4.Select((x, index) => string.Concat(Enumerable.Repeat(x, index+1)));
            string step6 = string.Join(Environment.NewLine, step5);
            //string step6 = string.Join("\n", step5);
            Console.WriteLine($"{step6}");
            Console.ReadLine();

            /*簡寫
            Console.WriteLine(
                string.Join(
                    Environment.NewLine,
                    Enumerable.Range(1, int.Parse(Console.ReadLine()))
                    .Reverse()
                    .Select((x, index) => string.Concat(Enumerable.Repeat(x, index + 1)))
                    )
                );
            */
        }
    }
}
