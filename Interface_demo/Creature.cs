using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_demo
{
    abstract class Creature //abstract不可直接建立物件
    {
        protected int hp = 100;

        public virtual string say() //virtual 子類可override
        {
            return "hi~ i'm " + getName() + ", i have " + hp + " blood";
        }
        public void injured(int damage)
        {
            hp -= damage;
        }
        public abstract string getName(); //abstract-->子類實作內容
    }
}
