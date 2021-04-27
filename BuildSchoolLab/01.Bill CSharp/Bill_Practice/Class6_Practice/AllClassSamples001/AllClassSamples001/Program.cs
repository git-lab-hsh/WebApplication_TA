using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSamples001
{
    class Program
    {
        static void Main(string[] args) //每個執行個體皆呼叫了自己的覆寫後的 GetArea
        {
            MyShape rec = new MyRectangle() { Width = 10, Heigh = 10 }; //可直接用MyShape這個變數型別，不用寫MyRectangle
            MyShape cir = new MyCircle() { Radius = 3 };
            //MyShape shape = new MyShape(); //無法建立抽象類型的執行個體;
            Console.WriteLine($"三角形的面積是：{rec.GetArea()}");
            Console.WriteLine($"圓形的面積是：{cir.GetArea()}");
            Console.ReadLine();
        }
    }

    public class MyRectangle : MyShape
    {
        public double Width { get; set; }
        public double Heigh { get; set; }
        public override double GetArea()
        {
            //throw new NotImplementedException();
            return Width * Heigh;
        }
    }

    public class MyCircle : MyShape
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
            //Math.PI 是一個唯讀欄位，代表 π
            //Math.Pow 是一個靜態方法，代表乘冪運算(就是x 的 y 次方這種)
        }
    }

    public abstract class MyShape //宣告一個抽象類別
    {
        public abstract double GetArea(); //宣告一個抽象方法
    }
}
