using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //TopDown 方法(從目的開始解)
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Caculate(true);
        }

        private void Caculate(bool isAdd)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            if (!isAdd)
            {
                y = -y;
                label1.Text = (x + y).ToString();
            }
            else if
            {
                label1.Text = (x * y).ToString();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Caculate(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
