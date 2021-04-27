using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReplaceWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數(>90)：");
            var step1 = Enumerable.Range(1, int.Parse(Console.ReadLine()));
            var step2 = step1.Select(x => x % 15 == 0 ? "Dann" : (x%5==0?"Build":(x%3==0? "School":x.ToString())));

            //for(int i =1; i<=max;i++)
            //{
            //    Console.WriteLine($"{i}");

            //}
            Console.WriteLine(string.Join("\n",step2));
            Console.ReadLine();
        }
       
    }
}
