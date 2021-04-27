using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 6, 7, 8, 9, 10 };

            //foreach:型別 變數in陣列
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }

            //while:先判斷再做
            int i = 0;
            while (i < 6)
            {
                Console.WriteLine(nums[i]);
                i ++ ;
            }

            //do...while:先做再判斷
            int j = 0;
            do
            {
                Console.WriteLine(nums[j]);
                j ++;
            }

            while (j < 6);

        }
    }
}
