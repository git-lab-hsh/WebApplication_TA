using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample002
{
    class Program
    {
        private 
        static void Main(string[] args)
        {
            List<MyData02> list = CreateList();

            // Method Expression
            var people = list.Where((x) => x.Name == "Bill");
            /*上行可改寫成下述：
            var people = Enumerable.Where(list, (x) => x.Name == "Bill");
            */
            //var people = list.Where((x) => x.Name == "Bill").Select(x => x.Age);
            
            //顯示結果
            foreach (MyData02 person in people)
            {
                Console.WriteLine($"{person.Name} 是 {person.Age} 歲");
            }
            Console.ReadLine();

        }
        static List<MyData02> CreateList()
        {
            return new List<MyData02>()
            {
                new MyData02 { Name = "Bill", Age = 47 },
                new MyData02 { Name = "John", Age = 37 },
                new MyData02 { Name = "Tom", Age = 48 },
                new MyData02 { Name = "David", Age = 36 },
                new MyData02 { Name = "Bill", Age = 35 },
            };
        }
    }
}
