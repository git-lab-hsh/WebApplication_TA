using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample06
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            var person = list.FirstOrDefault((x) => x.Name =="李小龍");
            // 判斷回傳結果是否為 null
            if (person == null)
            {
                Console.WriteLine("查無此人");
            }
            else
                Console.WriteLine($"找到：{person.Name} - {person.Age}");
        }
        static List<MyData06> CreateList()
        {
            return new List<MyData06>()
            {
                new MyData06 { Name = "Bill", Age = 47 },
                new MyData06 { Name = "John", Age = 37 },
                new MyData06 { Name = "Tom", Age = 48 },
                new MyData06 { Name = "David", Age = 36 },
                new MyData06 { Name = "Bill", Age = 35 },
            };
        }
    }
}
