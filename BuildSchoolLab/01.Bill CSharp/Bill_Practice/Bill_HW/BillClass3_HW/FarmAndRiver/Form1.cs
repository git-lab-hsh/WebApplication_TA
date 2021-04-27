using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmAndRiver
{
    public partial class Form1 : Form
    {
        private List<string> _leftList;
        private List<string> _rightList;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetListBoxDataSource();
            ChangeData();
            Reset();

        }
        public void CreateList()
        {
            _leftList = new List<string>
            {
                "農夫", "羊", "狼", "菜"
            };
            _rightList = new List<string>();
        }

        private void SetListBoxDataSource()
        {

            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;
        }

        private void Reset()
        {
            CreateList();
            ChangeData();
        }
        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftList;
            listBox2.DataSource = _rightList;

            //當農夫在左岸時，往左按鈕關閉
            if (_rightList.Contains("農夫"))
            {
                button1.Visible = false;
                //button1.Enabled() = true
                button2.Visible = true;
            }
            else
            {
                button2.Visible = false;
                //button1.Enabled() = true
                button1.Visible = true;
            }


            //判斷左邊失敗
            if (_leftList.Contains("羊")) //失敗必要條件1:羊吃菜or羊被狼吃
            {
                if (!_leftList.Contains("農夫"))//失敗必要條件2:農夫不在
                {
                    if (_leftList.Contains("菜"))
                    {
                        MessageBox.Show("羊吃了菜!");
                        Reset();
                    }
                    else if (_leftList.Contains("狼"))
                    {
                        MessageBox.Show("狼吃了羊!");
                        Reset();
                    }
                }
            }
            //判斷右邊失敗
            if (_rightList.Contains("羊")) //失敗必要條件1:羊吃菜or羊被狼吃
            {
                if (!_rightList.Contains("農夫"))//失敗必要條件2:農夫不在
                {
                    if (_rightList.Contains("菜"))
                    {
                        MessageBox.Show("羊吃了菜!");
                        Reset();
                    }
                    else if (_rightList.Contains("狼"))
                    {
                        MessageBox.Show("狼吃了羊!");
                        Reset();
                    }
                }
                //判斷成功
                if (_rightList.Count() == 4)
                {
                    MessageBox.Show("成功渡河!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //從左岸到右岸:with農夫
            if (listBox1.SelectedItem.ToString() != "農夫")
            {

                if (listBox1.SelectedItem.ToString() == "羊")
                {
                    string item = (string)listBox1.SelectedItem;
                    _leftList.Remove(item);
                    _leftList.Remove("農夫");
                    _rightList.Add(item);
                    _rightList.Add("農夫");
                    ChangeData(); //判斷成功或失敗
                }
                else if (listBox1.SelectedItem.ToString() == "狼")
                {
                    string item = (string)listBox1.SelectedItem;
                    _leftList.Remove(item);
                    _leftList.Remove("農夫");
                    _rightList.Add(item);
                    _rightList.Add("農夫");
                    ChangeData();
                }
                else
                {
                    string item = (string)listBox1.SelectedItem;
                    _leftList.Remove(item);
                    _leftList.Remove("農夫");
                    _rightList.Add(item);
                    _rightList.Add("農夫");
                    ChangeData();
                }

            }
            else //若單選為農夫
            {
                _leftList.Remove("農夫");
                _rightList.Add("農夫");
                ChangeData();
            }
            //檢查左岸角色:判斷成功or失敗
            //bool checkleft = CheckLeft();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //從右岸到左岸:with農夫
            if (listBox2.SelectedItem.ToString() != "農夫")
            {

                if (listBox2.SelectedItem.ToString() == "羊")
                {
                    string item = (string)listBox2.SelectedItem;
                    _rightList.Remove(item);
                    _rightList.Remove("農夫");
                    _leftList.Add(item);
                    _leftList.Add("農夫");
                    ChangeData();
                }
                else if (listBox1.SelectedItem.ToString() == "狼")
                {
                    string item = (string)listBox2.SelectedItem;
                    _rightList.Remove(item);
                    _rightList.Remove("農夫");
                    _leftList.Add(item);
                    _leftList.Add("農夫");
                    ChangeData();
                }
                else
                {
                    string item = (string)listBox2.SelectedItem;
                    _rightList.Remove(item);
                    _rightList.Remove("農夫");
                    _leftList.Add(item);
                    _leftList.Add("農夫");
                    ChangeData();
                }

            }
            else //若單選為農夫
            {
                _rightList.Remove("農夫");
                _leftList.Add("農夫");
                ChangeData();
            }

            //檢查右岸角色:判斷成功or失敗

            //檢查左岸角色:判斷成功or失敗
        }
    }

}

