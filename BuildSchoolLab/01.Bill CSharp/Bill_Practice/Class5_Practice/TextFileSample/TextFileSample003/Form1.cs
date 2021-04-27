using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileSample003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = CreateData();//對應
   
        }

        private List<Restaurant> CreateData()
        {
            string fileName = "A53000000A-000003-003.csv";
            if (File.Exists(fileName))
            {
                return File.ReadLines(fileName).Skip(1) //跳過資料的第一行(標題)
                                               .Select(x => x.Split(','))
                                               .Select(x => new Restaurant
                                               {
                                                   Seq = int.Parse(x[0]),
                                                   DishName = x[1],
                                                   Shop = x[3],
                                                   Address = x[4],
                                                   Tel = x[5]
                                               }
                                               ).ToList();
            }
            return null;
        }
    }
}
