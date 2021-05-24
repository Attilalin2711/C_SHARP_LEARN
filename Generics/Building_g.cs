using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Building_g<P>
    {
        ///泛型寫法
        List<P> people = new List<P>();

        public void Add(P person)
        {
            people.Add(person);
        }

        public override string ToString()
        {
            String output = "This Buliding has:\r\n";

            for(int i = 0; i<people.Count;i++)
            {
                output += people[i].ToString() + "\r\n";
            }
            return output;
        }
    }
}
