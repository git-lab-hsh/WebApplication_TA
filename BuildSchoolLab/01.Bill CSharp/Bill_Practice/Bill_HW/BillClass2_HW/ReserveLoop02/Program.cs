using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveLoop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數數字：");
            string input = Console.ReadLine();
            int max = int.Parse(input);
            //解1-1
            for (int y = max; y >= 1; y--)
            {
                for (int x = 1; x <= max + 1 - y; x++)
                {
                    Console.Write(y);
                }
                Console.Write("\n");
            }
            /*解1-2
            for (int y = 1; y <= max; y++)
            {
                for (int x = 1; x <= y; x++)
                {
                    Console.Write(max - y +1 );
                }
                Console.WriteLine();
            }
            */

            /*解2
            int y = 0;
            for (int x = 0; x < max; x++)
            {
                y= max - x;
                string z = y.ToString();
                z = new string (Convert.ToChar(z),x+1);
                Console.WriteLine(z);
            }
            */            
            Console.ReadLine();

        }
    }
}
