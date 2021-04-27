using System;
using System.Collections.Generic;
//加入
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample001
{
    public class MyRectangle : IEquatable<MyRectangle>
    {
        public double Width { get; set; }
        public double Height { get; set; }



        public override bool Equals(object obj) //覆寫
        {
            Debug.WriteLine("object");
            MyRectangle r = obj as MyRectangle;
            return Equals(r);
            //return Equals(obj as MyRectangle); //obj若轉型失敗，bool的方法就會錯誤
        }

        public bool Equals(MyRectangle other) //多載，會改執行這段程式碼
        {
            Debug.WriteLine("Rect");
            return other != null &&
                   Width == other.Width &&
                   Height == other.Height;
        }

        public override int GetHashCode() //雜湊碼
        {
            int hashCode = 859600377;
            hashCode = hashCode * -1521134295 + Width.GetHashCode();
            hashCode = hashCode * -1521134295 + Height.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(MyRectangle left, MyRectangle right)
        {
            return EqualityComparer<MyRectangle>.Default.Equals(left, right);
        }

        public static bool operator !=(MyRectangle left, MyRectangle right)
        {
            return !(left == right);
        }

        public override string ToString() //覆寫，會跳出剩下還可覆寫的方法，自動新增
        {
            return $"寬:{Width};高:{Height}";
        }
    }

}
