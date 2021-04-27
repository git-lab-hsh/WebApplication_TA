using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_6_MathQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please keyin a integer number:");
            //int num = int.Parse(Console.ReadLine());
            //if (num > 1)
            //{
            //    int sum = 0;
            //    for (int i = 1; i <= num; i++)
            //    {
            //        int x = (i % 2 == 0 ? -1 : 1);
            //        sum +=  x*i;
            //    }
            //    Console.WriteLine(sum);
            //}
            //else
            //{ Console.WriteLine("請輸入>1的數字"); }
            //Console.ReadLine();


            //解2-代公式
            Console.Write("Please keyin a integer number:");
            int input = int.Parse(Console.ReadLine());
            int answer = 0;
            if (input % 2 == 0)
            {
                answer = input * -1 / 2;
            }
            else
            {
                answer = (input + 1) / 2;
            }
             Console.WriteLine($"{answer}");
            Console.ReadLine();
        }
    }
}
