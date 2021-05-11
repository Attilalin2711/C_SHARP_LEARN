using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    class Creature
    {
        public string name;

        public virtual string move()
        {
            return name + "move forward";
        }
        public virtual string attack(Creature target)
        {
            return name + " attack " + target.name;
        }
    }
}
