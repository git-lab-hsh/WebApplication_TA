using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_Caculator
{
    class Program
    {
        static Dictionary<string, Func<double, double, double>> _dic;
        static void Main(string[] args)
        {
            _dic = new Dictionary<string, Func<double, double, double>>
            {
                { "+",(x,y)=>x+y},
                { "-",(x,y)=>x-y},
                { "*",(x,y)=>x*y},
                { "%",(x,y)=>x%y}
            };
            Console.ReadLine();
        }

        static double Caculate(string @operator, double x, double y)
        {
            if (_dic.ContainsKey(@operator))
            {
                return _dic[@operator](x,y);
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}
