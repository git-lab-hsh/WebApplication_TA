using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
 //code排版快捷鍵Ctl+K+D
            int scoreAndy = 60;
            int scoreJimmy = 50;
            int scoreKevin = 70;
            string max;

            //if(條件)
            if (scoreAndy > scoreJimmy && scoreAndy > scoreKevin)
            {
                //true(如果是)
                max = "Andy";
            }
            else if(scoreJimmy > scoreAndy && scoreJimmy > scoreKevin)
            {
                //false(如果不是)
      
                    max = "Jimmy";
            }
            else
            {
                max = "Kevin";
            }

            Console.WriteLine($"第一名：{max}");
            Console.ReadLine();
        }
    }
}
