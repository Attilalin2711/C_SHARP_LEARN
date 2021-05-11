using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protect_use
{
    class Monster
    {
        private int hp = 100;  //只要Monster當前類可以使用,子類也無法讀寫
        protected int HP = 100;
        private string name;

        public Monster(string name)
        {
            this.name = name;//複習this用法,C#當名稱相同是會取近的使用,因此使用this可以明確區分同名稱變數或是參數(外界傳入)
        }
        public int getHP()   //無存取限制
        {
            return HP;
        }
        public virtual string introduceSelf()
        {
            return "i'm Monster";
        }
    }
}
