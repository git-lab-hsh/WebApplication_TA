using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWeekDays day = MyWeekDays.Sun;
            Console.WriteLine($"Today is {day}.");
            if (day == MyWeekDays.Mon)
            {
                Console.WriteLine("Today is Monday");
            }
            else
            {
                Console.WriteLine("Today is not Monday");
            }

            int i = (int)day;
            Console.WriteLine($"The value of {day} is {i}");

            Console.ReadLine();
        }
    }
}
