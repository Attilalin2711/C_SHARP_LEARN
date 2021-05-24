using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //一般繼承寫法
    class Building
    {
        List<Object> people = new List<Object>();

        public void Add(Object person)
        {
            people.Add(person);
        }

        public override string ToString()
        {
            String output = "this buliding have: \r\n";
            
            for(int i=0; i<people.Count; i++)
            {
                output += people[i].ToString() + "\r\n";
            }
            return output;
        }
    }
}
