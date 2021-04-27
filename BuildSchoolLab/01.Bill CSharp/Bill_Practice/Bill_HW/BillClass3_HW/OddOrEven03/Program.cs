using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven03
{
    class Program
    {
        static void Main(string[] args)
        {
            //解1(可用var宣告)
            Console.Write("請輸入一串數字：");
            string step1 = Console.ReadLine();
            string[] step2 = step1.Split(',');
            IEnumerable<int> step3 = step2.Select(x => int.Parse(x)); //select就是轉型成我要的樣子
            IEnumerable<int> step4 = step3.OrderBy(x => x); //OrderBy:排序
            IEnumerable<IGrouping<int,int>> step5 = step4.GroupBy(x => x % 2);//GroupBy:以"每個整數除以2的餘數"做分群
   
            IEnumerable<string> step6 = step5.Select(x => $"{(x.Key == 0 ? "偶數" : "奇數")}:{string.Join(",", x)}"); 
            Console.WriteLine(string.Join(Environment.NewLine, step6));
            Console.ReadLine();

            /*簡寫
            Console.WriteLine(
                string.Join(
                    Environment.NewLine,
                    Console.ReadLine().Split(',')
                    .Select(x => int.Parse(x))
                    .OrderBy(x => x)
                    .GroupBy(x => x % 2)
                    .Select(x => $"{(x.Key == 0 ? "偶數" : "奇數")}:{string.Join(",",x)}")
                    )
                   );
            */

            /*解2-Bill
             * 
            var input=Console.ReadLine();
            var result = input.Split(',')
                              .Select(int.Parse)
                              .OrderBy(x => x)
                              .GroupBy(x => x%2)
                              .OrderByDescending(x => x.Key)
                              .Select(x => string.Join(",",x));

            
            先把字串分隔成字串陣列
            把上面陣列的每一個字串轉換成int
            先排序
            依照每個整數除以2的餘數(偶0,奇1)來分群
            使用上面群組的key來排序(反向,因為奇數要在前面)
            群組的每一群內容要轉成字串，而且用逗號當作分隔符號
             */
        }
    }
}
