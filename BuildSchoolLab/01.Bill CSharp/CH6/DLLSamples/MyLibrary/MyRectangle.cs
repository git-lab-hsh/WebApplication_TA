using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryXXXX
{
    public class MyRectangle : object
    {
        public int Witdh { get; set; }
        public int Height { get; set; }

        public int GetArea()
        { return Witdh * Height; }
    }
}
