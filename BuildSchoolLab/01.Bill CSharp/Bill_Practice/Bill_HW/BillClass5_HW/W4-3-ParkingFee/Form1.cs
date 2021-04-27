using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4_3_ParkingFee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;

            TimeSpan parkingtime = end.Subtract(start); //時間差
            int day = parkingtime.Days;
            int hour = parkingtime.Hours;
            int minutes = parkingtime.Minutes;
            int seconds = parkingtime.Seconds;
            decimal totalminutes = day * 24 * 60 + hour * 60 + minutes + seconds*1/60;

            //int totalminutes = Convert.ToInt32(parkingtime.TotalMinutes); 
            
            //以分計價
            if (totalminutes >= 30)
            {
                if (totalminutes >= 30 || totalminutes <= 60)
                {
                    MessageBox.Show($"您的停車時間為{hour}小時{totalminutes - 60 * hour}分鐘");
                    label3.Text = ($"您需繳交{totalminutes * 1}元"); //1分鐘1元
                }
                else if (totalminutes > 60 || totalminutes < 120)
                {
                    MessageBox.Show($"您的停車時間為1小時{totalminutes-60*hour}分鐘");
                    decimal x = Convert.ToDecimal(totalminutes * 3 / 4);
                    label3.Text = ($"您需繳交{Math.Ceiling(x)}"); //無條件進位
                }
                else
                {
                    decimal x = totalminutes / 60;
                    MessageBox.Show($"您的停車時間為{day}天{hour-24*day}小時{totalminutes-24*day-60*hour}分鐘");
                    label3.Text = ($"您需繳交{totalminutes * 2}元");
                }

            }
            else
            {
                MessageBox.Show($"您的停車時間低於30分鐘");
                label3.Text=("您需繳交0元");
            }
        }
    }
}
