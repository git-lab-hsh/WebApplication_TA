using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = ReturnTryInt(90);
            Console.WriteLine($"結果是 {i}");
            Console.ReadLine();
        }
        static int ReturnTryInt(int i )
        {
            try
            {
                Console.WriteLine("進入 Try");
                if (i> 10)
                {
                    throw new Exception("故意發生例外");
                }
               
                return 99;
            }
            catch(Exception ex)
            {
                Console.WriteLine("進入 Catch");
               // Console.WriteLine(ex.ToString());
                return 88;
            }
            finally
            {
                Console.WriteLine("進入 finally");
            }
        }
    }
}
