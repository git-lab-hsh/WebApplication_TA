using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample003
{
    class Program
    {
        static void Main(string[] args)
        {
            // 建立來源資料
            List<string> source
                = new List<string> { "Bill", "John", "David", "Tom", "David" };

            MyCalss obj = new MyCalss();
            var result = obj.DoWhere(source, 
                                     delegate (string x) { return x == "David"; }
                                     );

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
