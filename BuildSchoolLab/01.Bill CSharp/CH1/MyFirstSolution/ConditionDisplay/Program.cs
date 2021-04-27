using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionDisplay
{



    class Program
    {
        /// <summary>
        /// 重點
        /// (1) 避免 magic number
        /// (2) 字串差補語法
        /// (3) int.Parse
        /// (4) if 條件式的順序
        /// (5) 有意義的命名
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int condition = 10;
            int value;
            Console.WriteLine("請輸入一個數字 :");
            string input = Console.ReadLine();
            value = int.Parse(input);
            if (value > condition)
            {
                Console.WriteLine($"輸入的值大於 {condition}");
                // old school
                //Console.WriteLine(string.Format("輸入的值大於 {0}", condition));
                // very old school
                // Console.WriteLine("輸入的值大於" + condition.ToString ());
                Console.ReadLine();
                return;
            }
           
                if (value < condition)
                {
                    Console.WriteLine($"輸入的值小於 {condition}");
                    // old school
                    //Console.WriteLine(string.Format("輸入的值小於 {0}", condition));
                    // very old school
                    //Console.WriteLine("輸入的值小於" + condition.ToString ());
                }
                else
                {
                    Console.WriteLine($"輸入的值等於 {condition}");
                    // old school
                    //Console.WriteLine(string.Format("輸入的值等於 {0}", condition));
                    // very old school
                    //Console.WriteLine("輸入的值等於" + condition.ToString ());
                }
            
            
        }
    }
}
