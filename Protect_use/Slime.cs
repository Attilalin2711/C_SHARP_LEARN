using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protect_use
{
    class Slime:Monster
    {
        private int hurtHP = 100;
        public Slime(string name):base(name)//base功能三(最常見):假設父類有設建構子,當繼承時子類建構子必須要求相同的建構子參數,
                                            //此時便可使用:base(name)直接將子類的建構子參數傳給父類的建構子參數
                                            //也可使用Slime():base("史萊姆")來減少使用者麻煩
        {
            //hp  -->private子類無法使用
            //protected好處可以使用父類的變數,也可以保護不受外界使用
            HP = 500;
            base.HP = 500;//base功能一:可存取父類變數
        }
        public override string introduceSelf()
        {
            //base功能二:儘管父類method已經被override, 仍然可以透過base存取原版的版本
            return base.introduceSelf()+" HP:" +HP;
        }

    }
}
