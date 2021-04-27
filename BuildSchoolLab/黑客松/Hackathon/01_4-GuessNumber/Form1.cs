using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_4_GuessNumber
{
    public partial class Form1 : Form
    {
        private string[] answer;
        private string[] input;
        private char[] CS;
        public Form1()
        {
            InitializeComponent();
            answer = new string[4] ;
            input = new string[] { "0", "0", "0", "0" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CS = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Random rd = new Random(); 

            for (int i = 9; i > 0; i--)
            {
                char x;
                int y;
                y = rd.Next(0,9); //用意為產生隨機數字的"y位置"
                //交換位置
                x = CS[y]; //x暫存y位置的值
                CS[y] = CS[i]; // 將產生的隨機數字位置裡面的值"存入"y位置
                CS[i] = x; //將y位置的舊值(x)存回i位置
            }
            
            for (int j = 0; j <= 3; j++)
            {
                answer[j] = CS[j].ToString();
            }
            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                textBox2.Text=($"哈哈~答案為:{string.Join("", answer)}！想不到吧~");
                button1.Enabled = true;
                textBox1.Text = null;
            }
            else
            {
                MessageBox.Show("請先開始遊戲");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (button1.Enabled == false)
            {
                //判斷例外情況
                if (textBox1.Text == "")
                {
                    MessageBox.Show("請輸入數字!");
                }
                else if (textBox1.Text.Any(x => !CS.Contains(x)))//若輸入的值不是數字
                {
                    MessageBox.Show("您僅能輸入數字!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else if (textBox1.Text.Length > 4)
                {
                    MessageBox.Show("您僅能輸入最多4個數字!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                //執行遊戲
                else
                {
                    
                    for (int i = 0; i < 4; i++)
                    {
                        input[i] = textBox1.Text.Substring(i, 1); //產生input中0-3位置的陣列
                    }
                    //判斷幾A幾B>>>可以用交集寫法(先判斷總共符合的數字數目)
                    var intersect = answer.Intersect(input).Count();
                    int A = 0;
                    int B = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        if (answer[j] == input[j]){A += 1;}
                    }
                        B = intersect - A;

                    //int A = 0;
                    //int B = 0;
                    //for (int i = 0; i < 4; i++)
                    //{
                    //    if (answer[i] == input[i]){ A += 1;}
                    //    else
                    //    {
                    //        for (int j = 0; j < 4; j++)
                    //        {
                    //            if (answer[i] == input[j])
                    //                B += 1;
                    //        }
                    //    }
                    //}

                    //判斷是否過關
                    if (A == 4)
                    {
                        textBox2.Text = ("恭喜破關!");
                        answer = null;
                    }
                    else
                    {
                        textBox2.Text += ($"您輸入的數字為：{string.Join("", input)}" + "，");
                        textBox2.Text += ($"{A}A{B}B" + "\r\n");
                        textBox1.Text = "";

                    }
                }
            }
            else
            {
                MessageBox.Show("請先開始遊戲");
                textBox1.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            button1.Enabled = true;
        }

    }
}
