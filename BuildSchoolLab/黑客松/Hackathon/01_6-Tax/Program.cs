using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_6_Tax
{
    class Program
    {
        //private static decimal[] _taxrange;
        //private static decimal[] _taxrate;
        private Dictionary<decimal, decimal> taxrange;


         static void Main(string[] args)
        {
            //_taxrange = new decimal[] {0, 540000, 1210000, 2420000, 4530000, 10310000 };
            //_taxrange = new decimal[] { 10310000, 4530000, 2420000, 1210000, 540000, 0 };
            //_taxrate = new decimal[] {0, 0.05m, 0.12m, 0.2m, 0.3m, 0.4m, 0.5m };
            //_taxrate = new decimal[] { 0.5m, 0.4m, 0.3m, 0.2m, 0.12m, 0.05m };

            Dictionary<decimal, decimal> taxrange = new Dictionary<decimal, decimal>()
            {
                { 10310000, 0.5m },
                { 4530000, 0.4m },
                { 2420000, 0.3m },
                { 1210000, 0.2m },
                { 540000, 0.12m },
                { 0, 0m }
            };

            Console.Write("請輸入您的年收入金額:");
            decimal input = decimal.Parse(Console.ReadLine());
            var tax = taxrange.Select((x) => x.Key < input ? 0 : (input - x.Key) * (x.Value[i+1]-x.Value));
            
            //decimal input = Convert.ToDecimal(Console.ReadLine().Replace(",", string.Empty));
            //decimal tax = 0;
            //for (int i = 0; i < _taxrange.Count(); i++)
            //{
            //    if (input > _taxrange[i])
            //    {
            //        tax += (input - _taxrange[i]) * (Decimal)(_taxrate[i+1]-_taxrate[i]);

            //        //從大到小:tax += (input - _taxrange[i]) * (Decimal)(_taxrate[i]);
            //        //從大到小:input = _taxrange[i];
            //    }
            //}
            Console.WriteLine($"您的應繳納稅額為：{tax.ToString("#,###.###")}");
            Console.ReadLine();
        }



    }
}
