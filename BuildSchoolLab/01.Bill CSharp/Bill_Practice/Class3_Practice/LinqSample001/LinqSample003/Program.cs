using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample003
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            var person1 = list.FirstOrDefault((x) => x.Age < 30);
            Console.WriteLine($"小於37歲的人第一個被找到的是：{person1.Name}");

            /* 因為找不到, 就會跳出例外
            var person2 = list.First((x) => x.Age < 30);
            Console.WriteLine($"小於30歲的人第一個被找到的是：{person2.Name}");
            */
        }

        static List<MyData03> CreateList()
        {
            return new List<MyData03>()
            {
            new MyData03 { Name = "Bill", Age = 47 },
            new MyData03 { Name = "John", Age = 37 },
            new MyData03 { Name = "Tom", Age = 48 },
            new MyData03 { Name = "David", Age = 36 },
            new MyData03 { Name = "Bill", Age = 35 },
            };
        }
    }
}
