using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSample001
{
    class Program
    {
        static void Main(string[] args) //宣告抽象類別
        {
            List<MyShape> shapes = new List<MyShape>
             {
                new MyRectangle() { Width =10,Height =10},
                new MyCircle() { Radius= 3},
                new MyCircle() { Radius= 5},
                new MyRectangle() { Width =10,Height =11},
             };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetArea());
            }
            shapes.ForEach(x => Console.WriteLine(x.GetArea()));
        }


    }

    //public abstract class MyShape  
    //{
    //    public abstract double GetArea(); //宣告抽象方法
    //}




}

