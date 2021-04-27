using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendCount00
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2018, 1, 1);
            int Y = d.Year;
            while (d.DayOfWeek != DayOfWeek.Saturday && d.DayOfWeek != DayOfWeek.Sunday)
            {
                d = d.AddDays(1);
            }
            if (d.DayOfWeek == DayOfWeek.Sunday) d = d.AddDays(-1);
            for (DateTime tempD = d; tempD.Year < (Y + 1); tempD = tempD.AddDays(7))
            {
                if (tempD.Year == Y)//假設第一個假日是禮拜六
                    Console.WriteLine("{0:yyyy/MM/dd} {1}", tempD.Date, tempD.DayOfWeek.ToString());
                if (tempD.AddDays(1).Year == Y)
                    Console.WriteLine("{0:yyyy/MM/dd} {1}", tempD.Date.AddDays(1), tempD.AddDays(1).DayOfWeek.ToString());
            }
            Console.ReadLine();
        }
    }
}
