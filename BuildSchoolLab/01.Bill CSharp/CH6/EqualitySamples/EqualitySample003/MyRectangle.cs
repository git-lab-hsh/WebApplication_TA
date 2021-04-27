using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualitySample003
{
    class MyRectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public bool Equals(MyRectangle other)
        {
            return (this.Height == other.Height) &&
                   (this.Width == other.Width);
        }

        public override bool Equals(object obj)
        {
            return this.Equals((MyRectangle)obj);
        }

        public override int GetHashCode()
        {
            var hashCode = 859600377;
            hashCode = hashCode * -1521134295 + Width.GetHashCode();
            hashCode = hashCode * -1521134295 + Height.GetHashCode();
            return hashCode;
        }
       
    }
}
