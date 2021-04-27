using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSamples001
{
    public delegate void SomeAction(string message);
    class Program
    {
        static void Main(string[] args)
        {
            SomeAction action1 = new SomeAction(ShowText);
            action1 += ShowMessage;
            action1.Invoke("第一個科目");
            //action1("第一個");

            Console.ReadLine();
        }

        static void ShowText(string msg)
        {
            Console.WriteLine($"ShowText {msg}");
        }

        static void ShowMessage(string str)
        {
            Console.WriteLine($"ShowMessage {str }");
        }
    }
}
