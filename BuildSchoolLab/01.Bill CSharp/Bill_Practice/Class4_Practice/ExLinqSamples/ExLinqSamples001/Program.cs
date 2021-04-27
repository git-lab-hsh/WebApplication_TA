using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSamples001
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            //計算list中年齡總和
            int total = list.Sum(x => x.Age);
            Console.WriteLine($"年齡的總和為{total}");
            //取得list中年齡最小值
            var minAge = list.Min(x => x.Age);
            Console.WriteLine($"年齡的最小值為{minAge}");
            //取得list中年齡最大值
            var maxAge = list.Max(x => x.Age);
            Console.WriteLine($"年齡的最大值為{maxAge}");
            //取得list中的數量
            //注意Count 和 Count()是不一樣的
            int count = list.Count();
            Console.WriteLine($"list總個數為： {count}");
            int CountofBill = list.Count(x => x.Name == "Bill");
            Console.WriteLine($"list中的Bill總數量為{CountofBill}");
            //取得list中所有年齡平均值
            var average = list.Average(x => x.Age);
            Console.WriteLine($"年齡的平均為{average}");
            Console.ReadLine();
        }
        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData() { Name = "Bill", Age = 47 },
                new MyData() { Name = "John", Age = 37 },
                new MyData() { Name = "Tom", Age = 48 },
                new MyData() { Name = "David", Age = 36 },
                new MyData() { Name = "Bill", Age = 35 },
            };
        }
    }
}
