using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            // 找出名稱為 Bill 中的最小 Age
            var min =list.Where((x) => x.Name == "Bill").Min((x) =>x.Age);
            Console.WriteLine("所有 Bill 中最小的年齡是 :" + min);

            // 計算名稱為 Bill 的年齡總和
            var total =list.Where((x) => x.Name == "Bill").Sum((x) => x.Age);
            Console.WriteLine("所有 Bill 的年齡總和是 :" + total);

            var average = list.Where((x) => x.Name == "Bill").Average((x) => x.Age);
            Console.WriteLine("所有 Bill 的年齡平均是 :" + average);


            Console.ReadLine();
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
