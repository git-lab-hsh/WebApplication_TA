using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_4_字串轉換
{
    class Program
    {
        private static List<Numbers> list;
       
        static void Main(string[] args)
        {
            ConvertNumber();
            Console.Write("請輸入四位數的阿拉伯數字：");
            var step1 = Console.ReadLine();
            var step2 = step1.Where(x => list.SelectMany(y=>y.ArabicNumb).Contains(x)).ToList();
        }

        public static void ConvertNumber()
        {
            list = new List<Numbers>()
            {
                new Numbers { ChineseWord = "零", ArabicNumb='0'},
                new Numbers { ChineseWord = "一", ArabicNumb='1'},
                new Numbers { ChineseWord = "二", ArabicNumb='2'},
                new Numbers { ChineseWord = "三", ArabicNumb='3'},
                new Numbers { ChineseWord = "四", ArabicNumb='4'},
                new Numbers { ChineseWord = "五", ArabicNumb='5'},
                new Numbers { ChineseWord = "六", ArabicNumb='6'},
                new Numbers { ChineseWord = "七", ArabicNumb='7'},
                new Numbers { ChineseWord = "八", ArabicNumb='8'},
                new Numbers { ChineseWord = "九", ArabicNumb='9'},
            };
        }
    }
}
