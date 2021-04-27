using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 32;
            string r1 = string.Format("現在的溫度是 {0} °C", i);
            Console.WriteLine(r1);
            string r1x = $"現在的溫度是 {i:00.0} °C";
            Console.WriteLine(r1x);

            int x = 1;
            int y = 8;
            string r2 =string.Format("{0} 加 {1} 等於 {2}", x, y, (x + y));
            Console.WriteLine(r2);
            string r2x = $"{x} 加 {y} 等於 {x + y}";
            Console.WriteLine(r2x);

            object[] array = new object[] { 11, 12, 13, 14, 15 };           
            string r3 = string.Format("{0},{1},{2},{3},{4}", array);
            Console.WriteLine(r3);
            Console.ReadLine();
        }
    }
}
