using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //解3
            Console.Write("請輸入一串數字：");
            string input = Console.ReadLine();
            string[] inputList = input.Split(',');

            //step1:先把inputList每一個值都轉成數字int
            int[] numberList = new int[inputList.Length];
            for (int i = 0; i < inputList.Length; i++)
            {
                numberList[i] = int.Parse(inputList[i]);
            }
            //step2:再排序 bubble sort
            for (int i = 0; i < numberList.Length; i++)
            {
                for (int j = i + 1; j < numberList.Length; j++)
                {
                    if (numberList[i] > numberList[j])
                    {
                        int temp = numberList[j];
                        numberList[j] = numberList[i];
                        numberList[i] = temp;
                    }
                }
            }
            //step3:再分類
            string odd = "";
            string even = "";

            foreach (int num in numberList) //將numberList轉int型別
                if (num % 2 == 0)
                {
                    if (even == "")
                    {
                        even = even + num;
                    }
                    else
                    {
                        even = even + "," +num;
                    }
                }
                else
                {
                    if (odd == "")
                    {
                        odd = odd + num;
                    }
                    else
                    {
                        odd = odd + ","+num;
                    }
                }
            Console.WriteLine($"偶數：{odd}");
            Console.WriteLine($"奇數：{even}");
            Console.ReadLine();
        }
    }
}
