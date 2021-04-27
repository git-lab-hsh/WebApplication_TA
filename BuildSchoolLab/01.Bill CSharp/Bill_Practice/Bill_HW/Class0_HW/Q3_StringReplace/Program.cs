using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int num =1; num <=100; num++)
            {
                if (num % 2 == 0 && num % 3 == 0)
                {
                    Console.WriteLine("金槍魚");
                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine("螃蟹");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("章魚");
                }
                else
                {
                    Console.WriteLine($"{num}");
                }
            }
            Console.ReadLine();
         
        }
    }
}
