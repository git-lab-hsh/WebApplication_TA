using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("請輸入一串數字：");
            string inputNum = Console.ReadLine();
            string[] numbsList = inputNum.Split(',');

            /*
             * Step1:array的型別轉換<string轉int>
             *  先把string型別的array轉成int型別的array，故先自訂一個新的int型別的array
             * step2：ToInt32的使用(只能針對單一字元使用,非陣列)，故需用迴圈處理array的每個數字(更改array的長度)
             *  使用array.resize(ref "自訂的int陣列" , "要變成的陣列長度")
             */

            int[] num_array = {};

            int num_length = numbsList.Length;
            Array.Resize(ref num_array, num_length);

            for (int i = 0; i < num_length; i++)
            {
                //將string型別的array的第[i]個位置的內容轉成int型別的array的第[i]個位置
                num_array[i] = Convert.ToInt32(numbsList[i]);
                //Console.WriteLine(num_array[i]);>>>驗證有沒有轉換成功
            }
            
            Array.Sort(num_array);
            //驗證有沒有排序好
            //for (int j = 0; j < num_length; j++)
            //{
            //    Console.WriteLine(num_array[j]);
            //}

            int num_odd = 0; //奇數有幾個
            int num_even = 0; //偶數有幾個
            int[] num_odd_arr = { }; //建立一個奇數的空array
            int[] num_even_arr = { }; //建立一個偶數的空array

            for (int x = 0; x < num_length; x++)
            {
                if (num_array[x] % 2 == 0)
                {
                    Array.Resize(ref num_even_arr, ++num_even);
                    num_even_arr[num_even - 1] = num_array[x];
                }
                else
                {
                    Array.Resize(ref num_odd_arr, ++num_odd);
                    num_odd_arr[num_odd - 1] = num_array[x];
                }
            }

            Console.Write("偶數：");
            for (int j = 0; j < num_even; j++)
            {
                if (j == num_even - 1)
                {
                    Console.Write(num_even_arr[j]+"\n");
                }
                else
                    Console.Write(num_even_arr[j] + ",");
            }
            
            Console.Write("奇數：");
            for (int j = 0; j < num_odd; j++)
            {
                if (j == num_odd - 1)
                {
                    Console.Write(num_odd_arr[j]+"\n");
                }
                else
                    Console.Write(num_odd_arr[j] + ",");
            }
            Console.ReadLine();

            /*判斷奇偶數--解2
            string isOdd = String.Join(",", num_odd_arr);
            Console.WriteLine($"奇數：{isOdd}");
            string isEven = String.Join("," , num_even_arr) ;
            Console.WriteLine($"偶數：{isEven}");
            */
        }
    }
}
    

