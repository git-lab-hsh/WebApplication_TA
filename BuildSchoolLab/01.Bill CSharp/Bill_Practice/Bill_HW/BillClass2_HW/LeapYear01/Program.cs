using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//加入類別
using System.Globalization;

namespace LeapYear01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個中華民國年份：");
            string year = Console.ReadLine();
            //解1-1
            int int_year = int.Parse(year);
            bool isLeap = DateTime.IsLeapYear(int_year);
            if (!isLeap)
            {
                Console.WriteLine("閏年");
            }
            else
            {
                Console.WriteLine("不是閏年");
            }

            //解1-2
            //Console.WriteLine(DateTime.IsLeapYear(int.Parse(Console.ReadLine()) + 1911) ? "閏年" : "不是閏年");

            //解2
            //int x = int.Parse(year);
            //int addyears = x + 1911;
            //if (addyears % 400 == 0 || (addyears % 4 == 0 && addyears % 100 != 0))
            //{ 
            //    Console.WriteLine("閏年"); 
            //}
            //else
            //    Console.WriteLine("不是閏年");
            Console.ReadLine();
        }
    }
}
