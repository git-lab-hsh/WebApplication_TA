//新增2
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//新增1
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonSample001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       async  private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            string uri =
            "https://lod2.apc.gov.tw/API/v1/dump/datastore/A53000000A-000003-001";
            
            string data = await  client.GetStringAsync(uri);

            // Task<string> task = client.GetStringAsync(uri);
            // string data = task.GetAwaiter().GetResult();

            var result1 = JsonConvert.DeserializeObject<Class1[]>(data);
            dataGridView1.DataSource = result1[0].result.records; //records對應到DataSource裡面
        }
    }
}
