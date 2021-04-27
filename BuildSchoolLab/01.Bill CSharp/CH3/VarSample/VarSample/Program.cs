using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarSample
{
    class Program
    {
        // var 不可以宣告在欄位，也就 class 區段
        // 以下的宣告就是不合法的
        // var xyz=1;
        static void Main(string[] args)
        {
            // var 宣告時一定要帶有指派運算子 (也就是 = )
            // 以下宣告也是不合法的
            // var x;

            // 以下宣告的 i 型別會是 int (System.Int32)
            // 因為等號右邊是個 10, 因此編譯器會推斷為 int
            var i = 10;
           

            // 以下宣告的 s 型別會是 string (System.String)
            // 因為等號右邊是個 "ABC" 字串, 因此編譯器會推斷為 string
            var s = "ABC";
            

            // 以下宣告的 data 型別會是 MyData Class
            // 因為等號右邊是呼叫 MyData 建立一個 MyData 型別的執行個體, 因此編譯器會推斷為 MyData
            var data = new MyData();

            //以下宣告的 d 型別會是 double (Syste.Double)
            // 因為等號右邊是個方法，回傳值的型別為 double, 因此編譯器會推斷為 double
            var d = GetDouble();            
        }

       static double GetDouble()
        {
            return 9.8;
        }
    }
}
