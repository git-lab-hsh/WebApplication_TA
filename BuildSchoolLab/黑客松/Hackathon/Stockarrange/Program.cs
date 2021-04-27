using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockarrange
{
    public class Product
    {
        public DateTime InDay { get; set; }
        public int Quantity { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Product>
            {
                new Product { InDay=new DateTime(2021,1,1), Quantity=10 },
                new Product { InDay=new DateTime(2021,1,2), Quantity=30 },
                new Product { InDay=new DateTime(2021,1,3), Quantity=30 },
                new Product { InDay=new DateTime(2021,1,4), Quantity=50 },
                new Product { InDay=new DateTime(2021,1,5), Quantity=100 },
            };

            //var output = list.Select((x, index) => $"{x.InDay.ToString("yyyy/MM/dd")}, {(index !=0 ? (x.Quantity - list[index - 1].Quantity) : x.Quantity )}");
            //Console.WriteLine(string.Join("\n",output));

            //解1 >>> index寫法若用於某個方法中傳進來的變成IEnumerable，會出錯
            //List<Product> products = new List<Product>();
            //int lastQuantity = 0;
            //foreach (var p in list)
            //{
            //    products.Add(new Product { InDay = p.InDay, Quantity = p.Quantity - lastQuantity });
            //    lastQuantity = p.Quantity;
            //}

            //解2
            int q = 0;
            var r = list.Select(x =>
            {
                var result = new Product { InDay = x.InDay, Quantity = x.Quantity - q };
                q = x.Quantity;
                return result;
            });

            foreach (var item in r)
            {
                Console.WriteLine($"{ item.Quantity},{item.Quantity}");
            }
            
            
            Console.ReadLine();
        }
    }
}
