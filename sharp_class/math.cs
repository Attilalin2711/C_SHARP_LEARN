using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_class
{
    class math
    {
        public static int static_max(int a,int b)
        {
            int result;

            if (a < b)
                result = b;
            else
                result = a;
            return result;
        }
        public  int max(int a, int b)
        {
            int result;

            if (a < b)
                result = b;
            else
                result = a;
            return result;
        }
    }
}
