using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //初階
            Console.WriteLine("=====基本=====");

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("\t");
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i}*{j} = {i * j} ");
                }
            }

            //進階1
            Console.WriteLine("=====基本排版=====");

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("\t");
                for (int j = 1; j <= 9; j++)
                {
                    int ans = i * j;
                    Console.Write("\t" + $"{i}*{j} = {ans} ");
                }
            }
            Console.WriteLine("\n");

            //進階2
            Console.WriteLine("=====基本排版2=====");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i}*{j}={i * j} ");
                    if (j < 9)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write("\n");
                    }
                }
                //變形1
                Console.WriteLine("=====直列=====");
                for (int i = 1; i <= 9; i++)
                {
                    for (int j = 1; j <= 9; j++) ;

                }

            }
        }
    }
}

