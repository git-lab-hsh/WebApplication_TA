using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibary
{
    public class MyRectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int GetArea()
        { return Width * Height; }
    }
}
