using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_demo
{
    class Villager:Creature,ITalkable
    {
        public override string getName()
        {
            return "Villager";
        }
        public string talkTo(Creature target)
        {
            return "Hi~" + target.getName() + "! i'm villager!";
        }

    }
}
