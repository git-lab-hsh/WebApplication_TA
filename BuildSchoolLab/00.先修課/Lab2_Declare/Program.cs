using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Declare
{
    class Program
    {
        static void Main(string[] args)
        {
 //1.形別(ex:int)、變數名稱(ex:number)、指派運算子(=符號)、值(ex:10)的應用
            string word = "你好";
            int number = 10;
//2.隱含型別var的使用，一定要初始化才可執行(宣告一個值)
            var box = "AAA";

            Console.WriteLine($"天線寶寶說{word}{number}");
            Console.ReadLine();
//3.記得切換專案方法執行

//天線寶寶說(你好)(word)
//{0}{1}應用:Console.WriteLine("天線寶寶說{0}{1}", word, number);
//string format應用:Console.WriteLine($"天線寶寶說{word}{number}");
        }
    }
}
