using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSample003
{
    class MyRectangle03
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area
        {
            get { return Width * Height; }
        }

    }
}
