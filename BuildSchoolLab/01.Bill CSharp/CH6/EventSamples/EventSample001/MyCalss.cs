using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample001
{
    public class MyCalss
    {

        public event EventHandler XChanged;      

        protected virtual void OnXChanged()
        {
            // null conditional operator
            XChanged?.Invoke(this, EventArgs.Empty );
        }
        private int _x;
        public int X
        {
            get { return _x; }
            set
            {
                if (_x != value)
                {
                    _x = value;
                    OnXChanged();                   
                }
            }
        }       
    }
}
