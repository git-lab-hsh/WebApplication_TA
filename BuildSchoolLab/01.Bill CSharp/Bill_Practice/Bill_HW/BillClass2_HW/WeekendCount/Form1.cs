using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekendCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
            
        //}

        //private static void WeekendCount(string year)
        //{

        //    int int_year = int.Parse(year);
        //    DateTime dt = new DateTime(int_year, 01, 01);

        //    var firstday = dt.DayOfWeek;  //先找該年度1/1為星期幾

        //    //bool isLeap = DateTime.IsLeapYear(int_year);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);
            DateTime date = new DateTime(year,1,1);

            int Sat = 0;
            int Sun = 0;

            while (date.Year == year)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday) Sat++;
                if (date.DayOfWeek == DayOfWeek.Sunday) Sun++;
                date = date.AddDays(1);
            }

            label2.Text = $"星期六有： {Sat.ToString()}天";
            label3.Text = $"星期日有： {Sun.ToString()}天";
            //MessageBox.Show($"星期六{}天,星期天{ }天") ;
        }

    }
}
