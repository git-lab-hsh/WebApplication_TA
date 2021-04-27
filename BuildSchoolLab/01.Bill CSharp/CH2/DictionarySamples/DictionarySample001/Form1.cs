using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionarySample001
{

    /// <summary>
    /// 注意各種不同新增方式
    /// </summary>
    public partial class Form1 : Form
    {
        private Dictionary<string, MyRectangle> _dictionary;
        public Form1()
        {
            InitializeComponent();
            CreateDictionary();
        }

        private void CreateDictionary()
        {
            _dictionary = new Dictionary<string, MyRectangle>();
            _dictionary.Add("D1", new MyRectangle { Width = 5, Height = 5 });
            _dictionary.Add("D2", new MyRectangle { Width = 10, Height = 10 });
            _dictionary.Add("D3", new MyRectangle { Width = 20, Height = 20 });
            _dictionary.Add("D4", new MyRectangle { Width = 100, Height = 100 });


            // 各種不同新增資料到 Dictionary 的方式  

            // (1) 集合初始設定式 (Collection Initializers)
            //_dictionary = new Dictionary<string, MyRectangle>
            //{
            //    {"D1" ,new MyRectangle { Width =5, Height=5 }},
            //    {"D2", new MyRectangle { Width = 10, Height = 10 }},
            //    {"D3", new MyRectangle { Width = 20, Height = 20 }},
            //    {"D4", new MyRectangle { Width = 100, Height = 100 }}
            //};

            // (2) 直接指派資料
            //_dictionary["D5"] = new MyRectangle { Width = 9, Height = 8 }; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            if (_dictionary.ContainsKey(key))
            {
                int area = _dictionary[key].GetArea();
                MessageBox.Show($"{key} 的面積為： {area}");
            }
            else
            {
                MessageBox.Show("查無資料");
            }
        }
    }
}
