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

            int n;
            int i;
            int ans;

            for {n} in range(1, 200);
            {
                ans = 1;
                i = 2;

                while (i < n)
                {
                    if (n % i == 0)
                    {
                        ans = 0;
                    }
                    i++ ;
                }

                if (ans == 1) ;
                {
                    Console.WriteLine($"{n}");
                    Console.ReadLine();
                }
            }

        }
    }
}
