using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructorSample001
{
    public class BaseClass
    {
        public int X { get; private set; }

        public BaseClass ()
        {
            X = 0;
        }

        public BaseClass (int y)
        {
            X = y;
        }
    }
}
