using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_demo
{
    class slime:Monster
    {
        public slime():base("slime")
        {
            hp = 500;
        }
        public override string attack()
        {
            return "slime is attacking";
        }
        public override string introduceSelf()
        {
            return base.introduceSelf() + "I'm Slime";
        }
    }
}
