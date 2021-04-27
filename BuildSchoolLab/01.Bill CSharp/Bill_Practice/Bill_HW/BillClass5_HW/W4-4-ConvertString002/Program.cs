using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_4_ConvertString002
{
    
    class Program
    {
        private static Dictionary<char, string> _dictionary;
        static void Main(string[] args)
        {
            _dictionary = CreateList();
            Console.Write("請輸入四位數的阿拉伯數字：");
            string input = Console.ReadLine();

            var output = input.Select(x => _dictionary[x]);
            Console.WriteLine(string.Concat(output));
            Console.ReadLine();

        }

        private static Dictionary<char,string> CreateList()
        //private void CreateList()
        {
            return  new Dictionary<char, string>
            {
                { '0',"零"},
                { '1',"一"},
                { '2',"二"},
                { '3',"三"},
                { '4',"四"},
                { '5',"五"},
                { '6',"六"},
                { '7',"七"},
                { '8',"八"},
                { '9',"九"},
            };

        }
    }
}
