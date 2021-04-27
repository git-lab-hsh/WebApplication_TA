using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSample001
{
    public class Resturants
    {
        public Restaurant[] Items { get; set; }
    }

    public class Restaurant
    {
        public int Seq { get; set; }
        public string name { get; set; }
        public string AlsoKnownAs { get; set; }
        public string shop { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string awards { get; set; }
    }

}
