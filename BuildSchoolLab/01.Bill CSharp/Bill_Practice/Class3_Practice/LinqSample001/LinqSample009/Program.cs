using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample009
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            string name = "Bill";
            bool isAllBill = list.All(x => x.Name == name);
            if (isAllBill)
            {
                Console.WriteLine($"全都是：{name}");
            }
            else
            {
                Console.WriteLine($"有些人不叫：{name}");
            }
            bool isAllOverForty = list.All(x => x.Age >= 40);
            if (isAllOverForty)
            {
                Console.WriteLine("大家都超過40歲");
            }
            else 
            {
                Console.WriteLine("有人不到40歲");
            }
            Console.ReadLine();
        }
        static List<MyData09> CreateList()
        {
            return new List<MyData09>()
            {
                new MyData09 { Name = "Bill", Age = 47 },
                new MyData09 { Name = "John", Age = 37 },
                new MyData09 { Name = "Tom", Age = 48 },
                new MyData09 { Name = "David", Age = 36 },
                new MyData09 { Name = "Bill", Age = 35 },
            };
        }
    }
}
