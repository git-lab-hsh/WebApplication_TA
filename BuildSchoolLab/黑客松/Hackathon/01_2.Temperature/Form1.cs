using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_2.Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool CtoF = radioButton1.Checked;
            bool FtoC = radioButton2.Checked;
            if (CtoF)
            {
                decimal c = decimal.Parse(textBox1.Text);
                decimal f = c * 9 / 5 + 32;
                label1.Text = f.ToString();
            }
            else if (FtoC)
            {
                decimal f = decimal.Parse(textBox1.Text);
                decimal c = (f-32)*5/9;
                label1.Text = f.ToString();
            }
            else
                MessageBox.Show("請先選擇轉換溫度類型");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            button13.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; //sender是你點的那個物件傳進來
            //var btn = (Button)sender; 
           
            if (btn.Text == ".")
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text += "0.";
                }
                else if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += btn.Text;
                }
            }
            else
                textBox1.Text += btn.Text;
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += 2;
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += 3;
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += 4;
        //}

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += 5;
        //}

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += 6;
        //}

        //private void button9_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += 7;
        //}

        //private void button10_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += 8;
        //}

        //private void button11_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += 9;
        //}

        //private void button12_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += 0;
        //}

        //private void button13_Click(object sender, EventArgs e)
        //{
        //    //int len = textBox1.Text.Length;
        //    //string lastchar = "";
        //    //if (len != 0)
        //    //{
        //    //    lastchar = textBox1.Text.Substring(len - 1, 1);
        //    //}
        //    if(textBox1.Text =="")
        //    {
        //        textBox1.Text += "0.";
        //    }
        //    else if (!textBox1.Text.Contains("."))
        //    {
        //        textBox1.Text += ".";
        //    }

        //}
    }
}
