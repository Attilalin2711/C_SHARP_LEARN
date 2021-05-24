using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_demo
{
    class Player:Creature,IAttackable,ITalkable
    {
        public override string getName()
        {
            return "Player";
        }
        /// 實作介面時須確保實作的版本為public,外面才看的到
        public void attack(Creature target)
        {
            target.injured(30);
        }
        public string talkTo(Creature target)
        {
            return "Hi~" + target.getName() + "! i'm player!";
        }
    }
}
