using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileSample001
{
    public partial class Form1 : Form
    {
        private string fileName;
        public Form1()
        {
            InitializeComponent();
            fileName = "test.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (File.Exists(fileName)) //若沒指定路徑，檔案會存在啟動目錄(bin>debug的預設路徑)
            {
                textBox1.Text = File.ReadAllText(fileName);
            }
            else
            {
                MessageBox.Show("檔案不存在");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileName, textBox1.Text);
            MessageBox.Show("存檔完成");
        }
    }
}
