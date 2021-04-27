using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample001
{
    public partial class Form1 : Form
    {
        private List<MyRectangle> list;


        //在 Form1 Class 中建立一個方法來初始化 _list
        private void CreateList()
        {
            list = new List<MyRectangle>();
            list.Add(new MyRectangle { Name = "D1", Width = 5, Height = 5 });
            list.Add(new MyRectangle { Name = "D2", Width = 10, Height = 10 });
            list.Add(new MyRectangle { Name = "D3", Width = 20, Height = 20 });
            list.Add(new MyRectangle { Name = "D4", Width = 100, Height = 100 });
        }
        public Form1()
        {
            InitializeComponent();
            //在 Form1 Class的建構式呼叫剛剛建立的方法
            CreateList();
            SetCombobox();
        }
        private void SetCombobox() 
        {
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyRectangle item = (MyRectangle)comboBox1.SelectedItem;
            MessageBox.Show($" {item.Name} 的面積為： {item.GetArea()}");
        }
    }
}
