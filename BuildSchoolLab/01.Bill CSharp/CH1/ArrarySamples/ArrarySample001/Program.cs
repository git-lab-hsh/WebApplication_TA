using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrarySample001
{
    class Program
    {
        static void Main(string[] args)
        {
            // 定義一個尚未初始化的一維陣列 (這會一直出現警告)
            int[] array0;
            

            //定義一個有五個元素一維陣列
            int[] array1 = new int[5];

            // 定義一個一維陣列，同時給予陣列的內容
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // 同上，語法糖的寫法
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // 定義一個 2X3 的二維陣列
            int[,] multiDimensionalArray1 = new int[2, 3];

            // 定義一個二維陣列，同時給予陣列的內容
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // 定義一個不規則陣列
            int[][] jaggedArray = new int[6][];

            // 設定不規則陣列的內容
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
          
        }
    }
}
