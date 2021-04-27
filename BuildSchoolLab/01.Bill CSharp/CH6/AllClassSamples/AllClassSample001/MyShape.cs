using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSample001
{
    /// <summary>
    /// 宣告一個抽象類別
    /// </summary>
    public abstract class MyShape
    {
        /// <summary>
        /// 宣告一個抽象方法
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();        
        
    }

    /// <summary>
    /// 方形，有長寬
    /// </summary>
    public class MyRectangle : MyShape
    {
        
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    /// <summary>
    /// 圓形，只需要半徑
    /// </summary>
    public class MyCircle : MyShape
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
