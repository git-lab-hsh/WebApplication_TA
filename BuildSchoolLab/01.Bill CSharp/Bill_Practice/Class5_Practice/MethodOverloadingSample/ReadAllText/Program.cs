using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
//先加上


namespace ReadAllText //此方法可:開啟檔案、讀取檔案中的所有文字，並將它傳回為字串
{
    class Program
    {
        static void Main(string[] args)
        {
            //此檔案內容只會copy一次
            string path = @"C:\Users\Aphone\OneDrive\桌面\C#\BuildSchoolLab\01.Bill CSharp\Bill_Practice\Class5_Practice\ReadAllText_bom.txt";
            //因ReadAllText用法回傳值為布林值
            if (File.Exists(path))
            {
                //重新編碼的字串
                string creatText = "Numbers: ";
                File.WriteAllText(path, creatText, Encoding.UTF8);
            }

            string appendText = "10, 11, 12, 13"+ Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);


            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            Console.ReadLine();

        }
    }
}
