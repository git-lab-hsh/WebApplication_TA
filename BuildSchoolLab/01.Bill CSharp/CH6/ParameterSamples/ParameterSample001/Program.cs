using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine($"x 的初始值為 {x}");
            int y = ChangeX(x);
            Console.WriteLine($"退出 ChangeX 方法回到 Main 方法後, x 的值為 {x}");
            Console.WriteLine($"退出 ChangeX 方法回到 Main 方法後, x 的值為 {y}");
            Console.ReadLine();
        }

        private static int ChangeX(int x)
        {
            Console.WriteLine($"進入 ChangeX 方法的時候, x 的值為 {x}");
            x = 10;
            Console.WriteLine($"在 ChangeX 方法重新指派後, x 的值為 {x}");
            return x;
        }
    }
}
