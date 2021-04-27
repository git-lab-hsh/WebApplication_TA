using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample008
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            string name = "David";
            bool result = list.Any(x => x.Name == name); //x為宣告方法的位置
            if (result) //當result這個區域變數的布林值結果為真
            {
                Console.WriteLine($"找到了：{name}");
            }
            else
            {
                Console.WriteLine($"找不到：{name}");
            }
            Console.ReadLine();
        }
        static List<MyData08> CreateList()
        {
            return new List<MyData08>()
            {
                new MyData08 { Name = "Bill", Age = 47 },
                new MyData08 { Name = "John", Age = 37 },
                new MyData08 { Name = "Tom", Age = 48 },
                new MyData08 { Name = "David", Age = 36 },
                new MyData08 { Name = "Bill", Age = 35 },
            };
        }
    }
}
