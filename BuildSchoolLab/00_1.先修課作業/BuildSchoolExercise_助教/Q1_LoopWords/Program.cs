using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_LoopWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一段文字: ");
            var words = Console.ReadLine();
            bool isLoop = true;

            for(int i = 0; i < ((words.Length / 2) + 1); i++)
            {
                if (words[i] != words[words.Length - 1 - i])
                {
                    isLoop = false;
                }
            }

            if(isLoop == true)
                Console.WriteLine("是");
            else
                Console.WriteLine("不是");

            Console.ReadLine();
        }
    }
}
