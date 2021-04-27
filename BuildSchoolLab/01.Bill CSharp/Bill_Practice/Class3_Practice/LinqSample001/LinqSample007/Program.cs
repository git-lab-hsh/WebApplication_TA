using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample007
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            var list = CreateList();

            var person = list.ElementAtOrDefault(index);
            if (person == null)
            {
                Console.WriteLine("查無此人");
            }
            else 
            {
                Console.WriteLine($"找到索引為：{index}的人是{person.Name}-{person.Age}歲");
            }
            Console.ReadLine();
        }

        static List<MyData07> CreateList()
        {
            return new List<MyData07>()
            {
                new MyData07 { Name = "Bill", Age = 47 },
                new MyData07 { Name = "John", Age = 37 },
                new MyData07 { Name = "Tom", Age = 48 },
                new MyData07 { Name = "David", Age = 36 },
                new MyData07 { Name = "Bill", Age = 35 },
            };
        }
    }
