using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class CadenasSubsecuentes
    {
        public static string subsecuente(string a, string b)
        {
            if (!a.Length.Equals(b.Length))
            {
                return "Error. Las cadenas no son de la misma longitud.";
            }
            string sub = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Equals(b[i]))
                {
                    sub += a[i];
                }
            }
            return sub;
        }

    }
}
