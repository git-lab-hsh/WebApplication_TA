using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSample001
{
    public abstract class MyShape
    {
        public abstract double GetArea(); //宣告抽象方法
    }
    public class MyRectangle : MyShape //繼承MyShape，並實作抽象類別
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            //throw new NotImplementedException(); 自動產生的程式碼需刪除
            return Width * Height;
        }
    }
}
