using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2; i <= 200; i++)
            {
                bool isPrime = true;
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0) 
                        isPrime = false;
                }

                if (isPrime == true)
                    Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
