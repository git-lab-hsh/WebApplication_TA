using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualitySample004
{
    class MyRectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public bool Equals(MyRectangle other)
        {
            return (Width == other.Width && Height == other.Height);           
        }

    }
}
