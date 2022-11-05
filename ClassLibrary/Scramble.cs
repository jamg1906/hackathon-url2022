using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Scramble
    {

        public static bool ScrambleSolution(string a, string b)
        {
            string a2 = new string(a.ToUpper().OrderBy(x => x).ToArray());
            string b2 = new string(b.ToUpper().OrderBy(x => x).ToArray());

            if (a2.Equals(b2))
            {
                return true;
            }

            return false;
        }
        
    }
}
