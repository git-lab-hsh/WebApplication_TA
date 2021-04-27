using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4_5_TrainTicket
{
    public partial class Form1 : Form
    {
        private List<string> startlist;
        private List<string> endlist;
        private List<string> traveltype;
        private List<string> tickettype;
        private Dictionary<string,int> station;
        public Form1()
        {
            CreateList();
            InitializeComponent();
            South();
            
            endlist = new List<string> { "台北", "新竹", "台中", "嘉義", "台南", "高雄" }; //為了顯示終點站選單內容
            North();
            Type();
        }
        private void CreateList()
        {
            startlist = new List<string> { "台北", "新竹", "台中", "嘉義", "台南", "高雄" };
            endlist = new List<string> { "台北", "新竹", "台中", "嘉義", "台南", "高雄" };
            traveltype = new List<string> { "單程票", "來回票" };
            tickettype = new List<string> { "全票", "優待票" };
            station = new Dictionary<string, int>
            {
                {"台北",0},{"新竹",1},{"台中",2},{"嘉義",3},{"台南",4},{"高雄",5}
            };
        }
        private void South() //起始
        {
           //comboBox1.DataSource = null;
            comboBox1.DataSource = startlist;
        }
        private void North() //終點
        {
            //comboBox2.DataSource = null;
            comboBox2.DataSource = endlist;
        }

        private void Type()
        {
            comboBox3.DataSource = traveltype;
            comboBox4.DataSource = tickettype;
        }

        private void SelectStation()
        {
            endlist = new List<string> { "台北", "新竹", "台中", "嘉義", "台南", "高雄" };

            if (radioButton1.Checked) //南下選單
            {
                endlist.RemoveRange(0, comboBox1.SelectedIndex+1); //一開始會跑一個default值為0，如果沒有newlist會變成0
            }
            else //北上選單
            {
                endlist.RemoveRange(comboBox1.SelectedIndex, startlist.Count() - comboBox1.SelectedIndex);
            }
            North();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SelectStation();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             SelectStation();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectStation();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int index1 = comboBox1.SelectedIndex;
            int index2 = comboBox2.SelectedIndex;
            var start = startlist[index1];
            var arrive = endlist[index2];
            
            var ticketArray = new int[6, 6] //二維陣列
            {
                { 0, 177, 375, 598, 738, 842 },
                { 177, 0, 197, 421, 560, 735 },
                { 375, 197, 0, 224, 363, 469 },
                { 598, 421, 224, 0, 139, 245 },
                { 738, 560, 363, 139, 0, 106 },
                { 842, 735, 469, 245, 106, 0 }
            };

            decimal price = ticketArray[station[start], station[arrive]];
            if (numericUpDown1.Value != 0)
            {
                if (price != 0)
                {
                    label5.Text = $"總票價為：{Discount(price)}元";
                }
                else
                {
                    MessageBox.Show("您的出發及抵達站為相同目的地!");
                    label5.Text = "試算結果：";
                }
            }
            else
            {
                MessageBox.Show("請選擇購票張數!");
            }
}

        private string Discount(decimal price) //需解決分支
        {
            var result = price.ToString();
            //全票+來回票
            if (comboBox3.SelectedItem.ToString() == traveltype[1] && comboBox4.SelectedItem.ToString() == tickettype[0])
            {
                price = price * 2 * 0.9M * numericUpDown1.Value;
                result = Convert.ToInt32(Math.Ceiling(price)).ToString();
            }
            //優惠票+單程票
            else if (comboBox3.SelectedItem.ToString() == traveltype[0] && comboBox4.SelectedItem.ToString() == tickettype[1]) 
            {
                price = price * 0.9M * numericUpDown1.Value;
                result = Convert.ToInt32(Math.Ceiling(price)).ToString();
            }
            //優惠票+來回票
            else if (comboBox3.SelectedItem.ToString() == traveltype[1] && comboBox4.SelectedItem.ToString()==tickettype[1]) //優惠票
            {
                price = price *2 * 0.81M * numericUpDown1.Value;
                result = Convert.ToInt32(Math.Ceiling(price)).ToString();
            }
            //全票+單程票
            else 
            {
                price = price * numericUpDown1.Value;
                result = Convert.ToInt32(Math.Ceiling(price)).ToString();
            }
            return result;
        }


    }
}
