using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入數字：");
            //解1-遞迴(效率差)
            long n;
            if (long.TryParse(Console.ReadLine(),out n))
            {
                for (long i = 1; i < n; i++)
                {
                    Console.WriteLine($"{foo(i).ToString()}");
                }
            }

            //解2
            int start = 0;
            int next = 1;
            while(start < 1836311903)
            {
                int temp = start;
                start = next;
                next = next + temp;
                Console.WriteLine(next);
            }
            Console.ReadLine();
        }
        
        static long foo(long i)
        {
            if (i==0||i==1)
            {
                return i;
            }
            else
                return foo(i - 1) + foo(i - 2);
        }
    }
}
