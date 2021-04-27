using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionarySamples001
{
    public partial class Form1 : Form
    {
        //先建立一個簡單的類別>>MyRectangle.cs
        //在 Form1 Class 中宣告一個 Dictionary
        private Dictionary<string, MyRectangle> dictionary;
        //在 Form1 Class 中建立一個方法來初始化 dictionary
        private void CreatDictionary()
        {
            //產生一個dictionary的執行個體
            dictionary = new Dictionary<string, MyRectangle>();
            dictionary.Add("D1", new MyRectangle { Width = 5, Height = 5 });
            dictionary.Add("D2", new MyRectangle { Width = 10, Height = 10 });
            dictionary.Add("D3", new MyRectangle { Width = 20, Height = 20 });
            dictionary.Add("D4", new MyRectangle { Width = 100, Height = 100 });

        }
        public Form1()
        {
            InitializeComponent();
            //在 Form1 Class的建構式呼叫剛剛建立的方法
            CreatDictionary();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //為 Button 的 Click 事件掛上一個委派方法
            string key = textBox1.Text;
            if (dictionary.ContainsKey(key))
            {
                int area = dictionary[key].GetArea();
                MessageBox.Show($"{key} 的面積為： {area}");
            }
            else
            {
                MessageBox.Show("查無資料");
            }
        }
    }
}
