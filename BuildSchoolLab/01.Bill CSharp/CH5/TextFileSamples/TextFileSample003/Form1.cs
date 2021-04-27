using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
            var list = CreateData();
            dataGridView1.DataSource = list;
            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
            
        }

        bool dishFlag = false;
        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var source = (List<Restaurant>)dataGridView1.DataSource;
           
            switch (e.ColumnIndex)
            {
                case 1:
                    if (dishFlag == false)
                    {
                        dataGridView1.DataSource = source.OrderBy((x) => x.DishName).ToList();
                    }
                    else
                    {
                        dataGridView1.DataSource = source.OrderByDescending((x) => x.DishName).ToList();
                    }

                    dishFlag = !dishFlag;
                    break;
                default:
                    dataGridView1.DataSource = source.OrderBy((x) => x.Seq).ToList();
                    break;
            }
           
        }

        //private List<Restaurant> CreateData()
        //{
        //    char[] splits = new char[] { ',' };
        //    string fileName = "102015.csv";
        //    List<Restaurant> result = new List<Restaurant>();
        //    if (File.Exists(fileName))
        //    {
        //        string[] lines = File.ReadAllLines(fileName);
        //        for (int i = 1; i < lines.Length ; i++)
        //        {
        //            string[] items = lines[i].Split(splits);

        //            var restaurant = new Restaurant
        //            {
        //                Seq = int.Parse(items[0]),
        //                DishName = items[1],
        //                Shop = items[3],
        //                Address = items[4],
        //                Tel = items[5]
        //            };
        //            result.Add(restaurant);
        //        }
        //    }

        //    return result;
        //}

        private List<Restaurant> CreateData()
        {           
            string fileName = "102015.csv";            
            if (File.Exists(fileName))
            {   
                return File.ReadLines(fileName).Skip(1)
                                               .Select(x => x.Split(','))
                                               .Select(x => new Restaurant
                                               {
                                                   Seq = int.Parse(x[0]),
                                                   DishName = x[1],
                                                   Shop = x[3],
                                                   Address = x[4],
                                                   Tel = x[5]
                                               }).ToList();
            }
            return null;
        }
    }
}
