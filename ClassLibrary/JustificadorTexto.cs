using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public  class JustificadorTexto
    {
        public string[] JustificadorTextoSolution(string[] texto, int max)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                if (i == texto.Length - 1)
                {
                     int faltantes = max - texto[i].Length;
                    texto[i] = texto[i] + new string(' ', faltantes);
                }
                else
                {
                    var temp = texto[i].Split(' ');
                    int caracteres = 0;

                    foreach (string palabra in temp)
                    {

                        caracteres += palabra.Length;
                    }

                    int faltantes = max - caracteres;

                    while (faltantes > 0)
                    {
                        if (temp.Length == 1)
                        {

                            for (int j = 0; j < temp.Length; j++)
                            {
                                temp[j] += " ";
                                faltantes--;
                                if (faltantes == 0) break;
                            }
                        }
                        else
                        {
                            for (int j = 0; j < temp.Length - 1; j++)
                            {
                                temp[j] += " ";
                                faltantes--;
                                if (faltantes == 0) break;
                            }
                        }
                    }
                    texto[i] = String.Join("", temp);
                }
            }

            return texto; ;
        }

    }
}
