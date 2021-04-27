using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnSample001
{
    class Program
    {
        static void Main(string[] args)
        {
             ReturnVoid();

            int i = ReturnInt();

        }

        static int ReturnInt()
        {
            Console.WriteLine("進入 ReturnInt");

            // 回傳值要與宣告的型別相同
            return 1;
        }

        static void ReturnVoid()
        {
            Console.WriteLine("進入 ReturnVoid");

            // 沒有回傳值時, return 若在整個方法的最後一行可以省略
            return;
            
        }
        
    }
}
