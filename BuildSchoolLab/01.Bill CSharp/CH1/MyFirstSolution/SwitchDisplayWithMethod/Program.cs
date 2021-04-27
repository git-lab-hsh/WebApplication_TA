using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDisplayWithMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("請輸入一個數字 :");
            string input = Console.ReadLine();
            value = int.Parse(input);
            string result = Program.GetResult(value);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static string GetResult(int i)
        {
            switch (i)
            {
                case 1:
                    return "數字是 1";
                case 2:
                    return "數字是 2";
                default:
                    return "數字不在條件內";
            }
        }
    }
}
