﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int i;
            do
            {
                result += i;
                i++;
            }
            while (i < 11);
            Console.WriteLine($"加總結果：{result}");
            Console.ReadLine();
        }
    }
}
