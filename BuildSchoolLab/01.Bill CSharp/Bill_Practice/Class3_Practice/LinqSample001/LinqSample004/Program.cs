using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample004
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            // 這裡的 person1 是單個物件, 也就是 MyData person1
            var person1 = list.LastOrDefault((x) => x.Age > 35);
            Console.WriteLine($"大於 35 歲的人最後一個被找到的是 : {person1.Name}");
            // 因為找不到, 就會跳出例外
            var person2 = list.Last((x) => x.Age > 50);
            Console.WriteLine($"大於 50 歲的人最後一個被找到的是 : {person2.Name}");
            Console.ReadLine();

        }
        static List<MyData04> CreateList()
        {
            return new List<MyData04>()
            {
            new MyData04 { Name = "Bill", Age = 47 },
            new MyData04 { Name = "John", Age = 37 },
            new MyData04 { Name = "Tom", Age = 48 },
            new MyData04 { Name = "David", Age = 36 },
            new MyData04 { Name = "Bill", Age = 35 },
            };
        }
    }
}
