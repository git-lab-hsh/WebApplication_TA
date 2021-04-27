using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPoolSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ABC";
            string s2 = "ABC";
            // "ABC" 為固定字串，因此 s1, s2 會指向字串池中的同一個 "ABC"
            Console.WriteLine(object.ReferenceEquals(s1, s2));
            int x = 1;
            string s3 = x.ToString();
            string s4 = x.ToString();
            // s3, s4 所指向的字串為程式產生，所以這兩個 "1"並非相同的物件
            Console.WriteLine (object.ReferenceEquals(s3, s4));
            Console.ReadLine();
        }
    }
}
