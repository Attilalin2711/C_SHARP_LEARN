using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Worker
    {
        private String name;

        public Worker(String name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "office worker:" + name;
        }
    }
}
