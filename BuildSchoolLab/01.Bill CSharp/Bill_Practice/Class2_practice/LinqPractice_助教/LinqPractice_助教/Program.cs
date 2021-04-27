using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice_助教
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            { 
                "Amy","Bill","Gimmy","Andy","Aron"
            };
            //找A開頭的
            var result1 = list.Find(x => x[0].ToString() == "A"); //Find()不屬於linq語法
            var result2 = list.Where(x => x[0].ToString() == "A");

            var result3 = list.Select((x,index) => index);//把字串變成索引值
            var result4 = list.Select(x => x.First().ToString());
            var result5 = list.Select(x => x.First() - 64);//把字母轉換成數字，數字跟字母差64
            var result6 = list.Select(x => x.ToUpper());
            var result7 = list.Select((x, index) => new Person() { Number = index + 1, Name = x});

            List<Person> person = new List<Person>
            {
                new Person {Name ="Gary", Number =1, City="台北" },
                new Person { Name = "Tim", Number = 2, City = "台中" },
                new Person {Name ="Amanda", Number =3, City="台南" }
            };

            //用Number排序
            var result8 = person.OrderBy(x => x.Number); //從小到大排序
            var result9 = person.OrderByDescending(x => x.Number); //從大到小排序

            //用居住地排序
            var result10 = person.Select(x => x.City == "台北");

            //有沒有住在桃園的人
            var result_11 = person.Any(x => x.City == "桃園");
            var result_12 = person.Contains(person.Find(x => x.City == "桃園"));

            Console.ReadLine();
            
        }
        
    }
    class Person
    {
        public int Number { get; set; }
        public string Name{ get; set; }
        public string City { get; set; }
    }
}
