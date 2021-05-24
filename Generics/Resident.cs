using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Resident
    {
        private String name;

        public Resident(String name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Resident:" + name;
        }
    }
}
