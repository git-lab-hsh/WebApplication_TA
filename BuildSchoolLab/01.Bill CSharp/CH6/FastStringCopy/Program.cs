using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace FastStringCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = ReadText();

            Console.WriteLine("=========預熱區塊==========");
            Console.WriteLine(MergerByString(data).Length);
            Console.WriteLine(MergerByStringbuilder(data).Length);  

            Console.WriteLine("===================");
            var watch = new Stopwatch();
            for (int i = 0; i < 30; i++)
            {
                watch.Start();
                MergerByString(data);
                watch.Stop();
                Console.WriteLine(watch.ElapsedTicks);
                watch.Reset();
                watch.Start();
                MergerByStringbuilder(data);
                watch.Stop();
                Console.WriteLine(watch.ElapsedTicks);                
                watch.Reset();
                Console.WriteLine("===================");
            }


            Console.ReadLine();

        }

        static string[] ReadText()
        {
            return File.ReadAllLines("SourceFile2.txt");
        }



        static string MergerByString(string[] data)
        {
            var result = string.Empty;
            for (int i = 0; i < data.Length; i++)
            {
                result += data[i];
            }
            return result;
        }

        static string MergerByStringbuilder(string[] data)
        {
            var result = new StringBuilder(data.Length);
            for (int i = 0; i < data.Length; i++)
            {
                result.Append(data[i]);
            }
            return result.ToString();
        }      
    }
}
