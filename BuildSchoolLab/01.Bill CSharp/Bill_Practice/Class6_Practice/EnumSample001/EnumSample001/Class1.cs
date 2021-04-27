using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample001
{
    public enum MyWeekDays
    {
        Sun, Mon, Tue, Wed, Thu, Fri, Sat //自動從0開始
    }

    public enum BrowserTypes
    {
        IE=1, Edge, FireFox, Chrom //設定從1開始
    }

    public enum SwitchTypes
    {
        On=0,Off=1 //全部值都手動設定
    }

}
