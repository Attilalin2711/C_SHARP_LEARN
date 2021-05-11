using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    class Monster:Creature
    {
        public Monster(String name)//Constructor-->要求建立物件時需要傳入一個參數name
        {
            this.name = name;
        }
        public override string move()
        {
            return name + "move back";
        }
        public string move2()
        {
            return name + "move forward";
        }

    }
}
