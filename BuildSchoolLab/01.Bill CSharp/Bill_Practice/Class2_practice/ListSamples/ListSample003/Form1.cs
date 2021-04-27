using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample003
{
    public partial class Form1 : Form
    {
        //在 Form1 Class 中宣告一個 List<T>
        private List<MyRectangle03> _list;
        public Form1()
        {
            InitializeComponent();
            CreatList();
            SetCombobox();
            //從InitializeComponent()貼上comboBox.1.SelectedIndexChanged的程式碼
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);

        }
        //在 Form1 Class 中建立一個方法來初始化 _list
        private void CreatList()
        {
            _list = new List<MyRectangle03>()
            {
            new MyRectangle03 { Name = "D1", Width = 5, Height = 5 },
            new MyRectangle03 { Name = "D2", Width = 10, Height = 10 },
            new MyRectangle03 { Name = "D3", Width = 20, Height = 20 },
            new MyRectangle03 { Name = "D4", Width = 100, Height = 100 }
            };

        }
        private void SetCombobox()
        {
            comboBox1.DataSource = _list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Area";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox theComboBox = (ComboBox)sender;
            int index = theComboBox.SelectedIndex;
            MyRectangle03 item = _list[index];
            MessageBox.Show($"取得索引 {index+1} 的面積為：{item.Area}");
            

        }
    }
}
