using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSamples002
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass o1 = new Class1();
            o1.Execute();
            o1.Begin();

            BaseClass o2 = new Class2();
            o2.Execute();
            o2.Begin();
            

            Console.ReadLine();
        }
    }

    public class BaseClass
    {
        public virtual void Execute()
        { Console.WriteLine("BaseClass Execute Method"); }

        public virtual void Begin()
        { Console.WriteLine("BaseClass Begin Method"); }
    }

    public class Class1 : BaseClass
    {
        public override void Execute()
        {
            //base.Execute();
            Console.WriteLine("Class1 Execute Method");
        }
    }

    public class Class2 : Class1
    {
        public override sealed void Execute()
        {
            //base.Begin();
            Console.WriteLine("Class2 Execute Method");
        }

        public override void Begin()
        {
            //base.Begin();
            Console.WriteLine("Class2 Begin Method");
        }
    }
}
