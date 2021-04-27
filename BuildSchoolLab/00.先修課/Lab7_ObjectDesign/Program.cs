using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_ObjectDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            CandyStore store_A = new CandyStore();
            store_A.StoreName = "Build店";
            store_A.Owner = "Dann";
            store_A.Candies = new string[] { "棒棒糖", "小熊軟糖" };

            store_A.ShowInfo();

            Console.WriteLine("------------------------------");

            CandyStore store_B = new CandyStore();
            store_B.StoreName = "School店";
            store_B.Owner = "Jimmy";
            store_B.Candies = new string[] { "沙士糖", "可樂糖", "酸梅糖" };

            store_B.ShowInfo();
            Console.ReadLine();
        }
    }

    //糖果店
    public class CandyStore
    {
        //店長
        public string Owner { get; set; }
        //店名
        public string StoreName { get; set; }
        //糖果種類清單
        public string[] Candies { get; set; }

        //顯示糖果店資訊
        public void ShowInfo() 
        {
            Console.WriteLine($"糖果店；{StoreName}");
            Console.WriteLine($"店長：{Owner}");
            Console.WriteLine($"糖果清單：");
            foreach (string candy in Candies)
            {
                Console.WriteLine($"    {candy}");
            }
        }
    }
}
