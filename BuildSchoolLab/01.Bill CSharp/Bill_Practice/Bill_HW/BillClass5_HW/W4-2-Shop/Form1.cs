using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4_2_Shop
{
    public partial class Form1 : Form
    {
        private List<Menu> list;
        private decimal sum;


        public Form1()
        {
            InitializeComponent();
            list = CreateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            list[0].Order = int.Parse(textBox1.Text);
            list[1].Order = int.Parse(textBox2.Text);
            list[2].Order = int.Parse(textBox3.Text);
            list[3].Order = int.Parse(textBox4.Text);

            sum = list[0].Total() + list[1].Total() + list[2].Total() + list[3].Total();
            label5.Text = ($"總計：{sum} 元");

            int IntSum = Convert.ToInt32(sum);
            //int a = IntSum % 1000;
            //int b = a % 500;
            //int c = b%100;
            //int d = c%50;
            //int f = d%10;
            //int g = f % 5;
            int[] dollars = new int[7] { 1000, 500, 100, 50, 10, 5, 1 };
            var output = string.Join(Environment.NewLine, dollars.Select((x, index) => x / index == 0 ? $"{x / index} : {x % (index - 1) / index}");
            MessageBox.Show($"{output}");
            //MessageBox.Show($"應收：1000-{IntSum/1000}張、500-{a/500}張、100-{b/100}張、50元-{c/50}個、10元-{d/10}個、5元{f/5}個、1元-{g}個");
        }

        List<Menu> CreateList()
        {
            return new List<Menu>()
                {
                    new Menu { Name = "高麗菜", Price = 30 , Order = 0},
                    new Menu { Name = "豆干", Price = 17 ,Order = 0},
                    new Menu { Name = "海帶", Price = 15 ,Order = 0},
                    new Menu { Name = "肉片", Price = 40 ,Order = 0}
                };

        }

    }
}
