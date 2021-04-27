using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_ArrayAndForloop
{
    class Program
    {
        static void Main(string[] args)
        {
            //陣列用法:int , string
            /* int[] numbers = new int[] { 1, 2, 3, 4, 5 }; 
             可簡寫成下方 */
            int[] numbers = { 1, 2, 3, 4, 5 };

            string[] words = { "Do", "Re", "Mi", "Fa", "So" };

            //取值
            /*
            Console.WriteLine(numbers[0]);
            Console.WriteLine(words[2]);
            */

            //For用法
                //*i=i+1可簡寫成i++ 
                 
            for (int i = 0; i < 5; i++ )
            {
                Console.WriteLine(words[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}
