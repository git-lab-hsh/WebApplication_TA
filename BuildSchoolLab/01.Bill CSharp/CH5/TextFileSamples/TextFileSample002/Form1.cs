using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileSample002
{
    public partial class Form1 : Form
    {
        private string fileName;
        public Form1()
        {

            InitializeComponent();
            this.Text = "002";
            fileName = "test.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                //foreach (var line in lines)
                //{
                //    textBox1.Text += $"{line}{Environment.NewLine}" ;
                //}     
               textBox1.Text =  string.Join(Environment.NewLine, lines); 
            }
            else
            { MessageBox.Show("檔案不存在"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileName, textBox1.Text);
            MessageBox.Show("存檔完成");
        }
    }
}
