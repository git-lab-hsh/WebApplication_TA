using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator03
{
    public partial class Form1 : Form
    {
        private MyData data;
        public Form1()
        {
            InitializeComponent();
            data = new MyData();
            //在Form1 Class建構式中為data產生一個執行個體
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate(false);
        }

        private void Calculate(bool add)
        {
            data.X = int.Parse(textBox1.Text);
            data.Y = int.Parse(textBox2.Text);
            if (add)
            {
                label1.Text = data.Add().ToString();
            }
            else 
            {
                label1.Text = data.Less().ToString();
            }
        
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
