using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSample002
{
    class MyRectangle02
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        //將Area改成屬性
        public int Area
        {
            get { return Width * Height; }
        }
    }
}
