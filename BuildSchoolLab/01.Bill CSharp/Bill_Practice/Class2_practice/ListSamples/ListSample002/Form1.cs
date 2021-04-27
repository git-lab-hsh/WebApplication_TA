using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample002
{
    public partial class Form1 : Form
    {
        private List<MyRectangle02> _list;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetCombobox();

        }

        private void CreateList()
        {
            _list = new List<MyRectangle02>()
            {
            new MyRectangle02 { Name = "D1", Width = 5, Height = 5 },
            new MyRectangle02 { Name = "D2", Width = 10, Height = 10 },
            new MyRectangle02 { Name = "D3", Width = 20, Height = 20 },
            new MyRectangle02 { Name = "D4", Width = 100, Height = 100 }
            };
        }

        public void SetCombobox()
        {
            comboBox1.DataSource = _list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Area";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int area = (int)comboBox1.SelectedValue; //object型別轉換成int
            MessageBox.Show(area.ToString()); //int型別轉換成string
            //MessageBox.Show($"面積：{area}"); 上面也可寫成此行
        }
    }
}
