using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串以逗號分隔的數字：");
            string inputNum = Console.ReadLine();
            string[] inputList = inputNum.Split(','); //Split裡面傳入的參數是char字元，所以要用單引號
            int num_length = inputList.Length;
            //解1
            Array.Reverse(inputList);
            for (int i=0; i<num_length; i++)
            {
                if (i == num_length-1)
                {
                    Console.Write(inputList[i]);
                }
                else
                {
                    Console.Write($"{inputList[i]}"+",");
                }
            }
            Console.ReadLine();

            /*解2
            string answer = "";
            for (int i = inputList.Length - 1; i >= 0; i--)
            {
                if (answer == "")
                {
                    answer = answer + inputList[i];
                }
                else 
                {
                    answer = answer + "," + inputList[i];
                }
            }
            */
   
        }
    }
}
