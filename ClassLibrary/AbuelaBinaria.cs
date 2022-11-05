using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class AbuelaBinaria
    {
        public static int AbuelaBinariaSolution(int n1, int n2, int res)
        {
            if ((n1 + n2) != res)
            {
                Console.WriteLine("Los números ingresados no son válidos");
                return -1;
            }

            var total = Convert.ToString(n1, 2) + Convert.ToString(n2, 2);

            int avellanas = 0;

            foreach (var item in total)
            {
                avellanas += Convert.ToInt32(item.ToString());
            }

            return avellanas;
        }


    }
}
