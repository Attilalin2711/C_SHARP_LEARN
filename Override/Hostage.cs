using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    class Hostage:Creature
    {
        public Hostage(string name)
        {
            this.name = name;
        }
        ///通常人質不具攻擊能力,但Creature裡定義了攻擊方法
        ///但不繼承Creature又喪失了其他屬性,重新建立代價太高(需要花時間把需要的功能再寫一次)
        ///Override可以改寫繼承到的行為
        ///需要在被改寫的method前加上virtual
        ///改寫method前加上override
        public new string move()
        {
            return name + " move right ";
        }
        public override string attack(Creature target)//override的method參數需與被override的方法相同
        {
            return "Hostage has no force";
        }
    }
}
