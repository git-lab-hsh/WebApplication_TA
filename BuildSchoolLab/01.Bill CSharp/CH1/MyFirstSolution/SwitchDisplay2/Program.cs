using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDisplay2
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("請輸入一個數字 :");
            string input = Console.ReadLine();
            value = int.Parse(input);
            switch (value)
            {
                case 1:

                case 2:
                    Console.WriteLine("數字是 1 或 2");
                    break;
                default:
                    Console.WriteLine("數字不在條件內");
                    break;
            }
            Console.ReadLine();
        }
    }
}
