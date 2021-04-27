using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator03
{
    class MyData
    {
      //參考型別，可用來宣告變數
         private int x; 
         private int y;

        public int X
        {
            get { return x ; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        //為 MyData 加入 Add 與 Less 方法
        public int Add()
        {
            return X + Y;
        }
        public int Less()
        {
            return X - Y;
        }
    }
}
