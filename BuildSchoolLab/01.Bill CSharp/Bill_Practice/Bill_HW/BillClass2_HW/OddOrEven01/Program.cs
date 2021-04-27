using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write ($"請輸入數字：");
            /*解1-1
             string型別強制轉換成int型別
             string input = Console.ReadLine();
             int number = int.Parse(input);
            */

            //解1-2
            var number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("偶數");
            }
            else
            {
                Console.WriteLine("奇數");
            }
            Console.ReadLine();

            //解2--三元判斷式(?:用法)
            //Console.WriteLine(int.Parse(Console.ReadLine()) % 2 == 0 ? "偶數" : "奇數");

        }
    }
}
