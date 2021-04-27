using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualitySample001
{
   class MyRectangle : IEquatable<MyRectangle>
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public bool Equals(MyRectangle other)
        {
            throw new NotImplementedException();
        }
    }

   
}
