using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_demo
{
    class Monster:Creature,IAttackable
    {
        public override string say()
        {
            return "hohoho~ (Hp:"+ hp + ")";
        }
        public override string getName()
        {
            return "Monster";
        }
        public void attack(Creature target)
        {
            target.injured(5);
        }
    }
}
