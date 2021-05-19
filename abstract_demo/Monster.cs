using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_demo
{
    abstract class Monster ///抽象類別內可放置抽象方法,但abstract後無法實體化Monster類別
    {
        protected int hp = 10;
        private string name;
        
        public Monster(string name)
        {
            this.name = name;
        }
        ///什麼是抽象方法?
        /// Method的組成: 1.宣告 2.內容(實際執行方式)
        /// abstract method 不具有內容
        public abstract string attack();
 
        public int getHp()
        {
            return hp;
        }
        public virtual string introduceSelf()
        {
            return "I'm Monster!";
        }
    }
}
