using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForm
{
    public partial class Form1 : Form
        //":"代表繼承>Form1繼承Form裡面的程式碼
        //"partial"代表部分檔案，表示一個類別有好幾個檔案
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Windows Forms!");
        }
    }
}
