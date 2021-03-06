using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSamples002
{
    public delegate bool MyPredicate(string value);
    class Program
    {
        static void Main(string[] args)
        {
            List<string> source1 = new List<string> { "Bill", "John", "David", "Tom", "David" };
            //MyClass obj = new MyClass();
            //MyPredicate predicate1 = SearchDavid; 
            //var result2 = DoWhere(source1, SearchDavid);
            //var result2 = DoWhere(source1, delegate (string x) { return x == "David"; });
            var result2 = DoWhere(source1, x => x == "David" );
            foreach (var item1 in result2)
            {
                Console.WriteLine(item1);
            }
            Console.ReadLine();
        }
        public static List<string> DoWhere(List<string> source, MyPredicate predicate)
        {
            List<string> result = new List<string>();
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;

        }
        //static bool SearchDavid(string value)
        //{
        //    return (value == "David");
        //}
    }
    public class MyClass
    {
        //public List<string> DoWhere(List<string> source, MyPredicate predicate)
        //{
        //    //DoWhere 本身不知道該怎麼判斷，完全靠 predicate 告訴它該怎麼判斷，所以我們會從外部傳進判斷式
        //    List<string> result = new List<string>();
        //    foreach (var item in source)
        //    {
        //        if (predicate(item))
        //            result.Add(item);
        //    }
        //    return result;

        //}
    }
}
