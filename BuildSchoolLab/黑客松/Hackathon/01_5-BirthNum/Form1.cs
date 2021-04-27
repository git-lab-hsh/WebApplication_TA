using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.IO;

namespace _01_5_BirthNum
{
    public partial class Form1 : Form
    {
        private int birthnum;
        private string[] info;
        private DateTime input;
        public Form1()
        {
            InitializeComponent();
            info = File.ReadAllLines("生命靈數_hsh.txt");

        }

        public string GetAtom(DateTime input)
        {
            float finput = Convert.ToSingle(input.ToString("M.dd"));
            float[] atomBound = { 1.00F, 1.20F, 2.20F, 3.21F, 4.21F, 5.21F, 6.22F, 7.23F, 8.23F, 9.23F, 10.23F, 11.21F, 12.22F, 12.31F};
            string[] atoms = { "摩羯座","水瓶座", "雙魚座", "牧羊座", "金牛座", "雙子座", "巨蟹座", "獅子座", "處女座", "天秤座", "天蠍座", "射手座", "魔羯座" };
            string ret = string.Empty;
            for (int i = 0; i < atomBound.Length; i++)
            {
                if (atomBound[i] <= finput && atomBound[i + 1] > finput)
                {
                    ret = atoms[i];
                    break;
                }
            }
            return ret;
        }

        public void BirthNum()
        {
            input = dateTimePicker1.Value;
            var inputyear = Convert.ToString(input.Year);
            var inputmonth = input.Month.ToString();
            var inputdate = input.Day.ToString();
            var alldays = inputyear + inputmonth + inputdate;
            int alldayslength = alldays.Length;

            int[] num;
            num = new int[8];
            for (int i = 0; i < alldayslength; i++)
            {
                num[i] = int.Parse(alldays.Substring(i, 1));
            }

            birthnum = num.Sum();
            while (birthnum > 9)
            {
                int temp = 0;
                int[] birthtotal;
                birthtotal = new int[2];
                for (int i = 0; i < 2; i++)
                {
                    birthtotal[i] = int.Parse(birthnum.ToString().Substring(i, 1));
                    temp += birthtotal[i];
                }
                birthnum = temp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BirthNum(); //確保重選日期可再重算一次

            //取得檔案中星座位置及說明
            string atomindex = GetAtom(input);
            int index = info.ToList().IndexOf(info.FirstOrDefault(x =>x.Contains(atomindex)))+birthnum*2;
            string birthnumtex = info[index];
           
            textBox1.Text = ($"您是：{atomindex}{Environment.NewLine}{ birthnumtex}"); 
        }
    }
}

