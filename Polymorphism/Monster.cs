using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Monster
    {
        /// 範例二
        /// 假設Monster可以攻擊palyer與village
        /// 此時不用分別寫兩個attack函數
        /// 可以直接將attack的傳入變數設為Creature變數
        /// 如此外面操坐時, 不管是player變數或是village變數都可傳入
        public void attack(Creature　c)
        {
            c.injured(10);
        }

    }
}
