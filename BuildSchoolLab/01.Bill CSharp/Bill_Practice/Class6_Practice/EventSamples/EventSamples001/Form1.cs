using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSamples001
{
    public partial class Form1 : Form
    {
        private MyCalss obj;
        public Form1()
        {
            InitializeComponent();
            obj = new MyCalss();
            obj.XChanged += Obj_XChanged; //事件背後會長出一個委派的欄位出來


        }
        private void Obj_XChanged(object sender, EventArgs e)
        {
            MessageBox.Show("X 的值改變了");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.X += 1;
        }
    }
    public class MyCalss
    {
        private EventHandler _xChanged;

        public event EventHandler XChanged
        {
            add{_xChanged += value; }
            remove{_xChanged -= value;}
        }

        protected virtual void OnXChanged()
        {
             _xChanged?.Invoke(this, EventArgs.Empty);
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
