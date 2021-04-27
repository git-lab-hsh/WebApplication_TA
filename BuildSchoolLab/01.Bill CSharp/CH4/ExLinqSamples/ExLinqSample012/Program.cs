using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample012
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            var order1 =
                from o in list
                orderby o.Name, o.Age
                select o;
            Display(order1);
            var order2 =
              from o in list
              orderby o.Name descending , o.Age descending
              select o;
            Display(order2);
            Console.ReadLine();
        }

        static void Display(IOrderedEnumerable<MyData> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item.Name + " : " + item.Age);
            }
            Console.WriteLine("-------------");
        }
        static List<MyData> CreateList()
        {
            var list = new List<MyData>();
            list.Add(new MyData() { Name = "Bill", Age = 47 });
            list.Add(new MyData() { Name = "John", Age = 37 });
            list.Add(new MyData() { Name = "Tom", Age = 48 });
            list.Add(new MyData() { Name = "David", Age = 36 });
            list.Add(new MyData() { Name = "Bill", Age = 35 });
            return list;
        }
    }
}
