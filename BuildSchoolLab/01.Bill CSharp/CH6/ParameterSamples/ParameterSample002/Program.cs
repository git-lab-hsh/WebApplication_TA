using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 0;
            //Console.WriteLine($"x 的初始值為 {x}");
            //int y = ChangeX(ref x);
            //Console.WriteLine($"退出 ChangeX 方法回到 Main 方法後, x 的值為 {x}");
            //Console.ReadLine();

            string student = "大熊";
            int x = 100;
            Console.WriteLine($"名字為{student},編號{x}");
            string student01 = ChangeName(ref student);
            Console.WriteLine($"名字為{student},編號{x}");
            Console.ReadLine();

        }

        private static string ChangeName(ref string student)
        {
            int x = 101;
            Console.WriteLine($"名字為{student},編號{x}");
            student = "多拉a夢";
            Console.WriteLine($"名字為{student},編號{x}");
            return student;
        }
        //private static int ChangeX(ref int x)
        //{
        //    Console.WriteLine($"進入 ChangeX 方法的時候, x 的值為 {x}");
        //    x = 10;
        //    Console.WriteLine($"在 ChangeX 方法重新指派後, x 的值為 {x}");
        //    return x;
        //}
    }
}
