using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            // 建立來源資料
            List<string> source
                = new List<string> { "Bill", "John", "David", "Tom", "David" };


            MyCalss obj = new MyCalss();
            // 傳統的具名寫法
            MyPredicate predicate = SearchDavid;            
            var result = obj.DoWhere(source, predicate );          
           

            // 以上兩行行加上 SearchDavid 方法可以用匿名委派的寫法
            // 請看 DelegateSample003

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static bool SearchDavid(string value)
        {
            return (value == "David");
        }
    }

   
}
