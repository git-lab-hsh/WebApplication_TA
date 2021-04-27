using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //建立一個方法後可以重複使用
            SaySomething("Build");
            SaySomething("School");

            //宣告一個answer1去回傳Add這個方法裡面的值
            int answer1 = Add(10, 20);
            int answer2 = Add(7, 8);
            //回傳的值(x+y)需要另一個變數(answer1,anser2)去接收回傳回來的值
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);

            Console.ReadLine();
        }

        //無回傳值方法:void
        static void SaySomething(string word)
        {
            Console.WriteLine(word);
        }

        //有回傳值方法:需要建立一個回傳值(return用法)
        static int Add(int x, int y)
        {
            int ans = x + y;
            return ans;
            Console.WriteLine(ans);
        }
    }
}
