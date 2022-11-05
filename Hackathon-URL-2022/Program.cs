using ClassLibrary;

namespace Hackathon_URL_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            try
            {
                while (!input.Equals("5")){
                    mensaje();
                    input = Console.ReadLine();
                    Console.Clear();
                    if (input == "1")
                    {
                        Scramble scramble = new Scramble();
                        Console.WriteLine("Problema 1: Scramble, por favor ingrese dos cadenas");
                        Console.WriteLine("Cadena 1: ");
                        string a = Console.ReadLine();
                        Console.WriteLine("Cadena 2: ");
                        string b = Console.ReadLine();

                        Console.Clear();
                        if (a.Count() != b.Count())
                        {
                            Console.WriteLine("Ingrese dos cadenas de la misma longitud.");
                            throw new Exception();
                        }

                        Console.WriteLine("Resultado: " + scramble.ScrambleSolution(a, b).ToString());

                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (input == "2")
                    {
                        Console.WriteLine("Problema 2: Justificador de Texto");
                        string[] test = { "This is an", "example of text", "justification." };
                        var res = new JustificadorTexto().JustificadorTextoSolution(test, 16);
                        foreach (string s in res)
                        {
                            Console.WriteLine(s);
                        }

                        Console.ReadKey();
                        Console.Clear();

                    }
                    else if (input == "3")
                    {

                    }
                    else if (input == "4")
                    {
                        Console.WriteLine("Problema 4: Abuela Binaria");
                        AbuelaBinaria abuelaBinaria = new AbuelaBinaria();
                        Console.WriteLine("Ingrese el primer número");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el resultado de la suma");
                        int res = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La abuela dará: " + abuelaBinaria.AbuelaBinariaSolution(n1, n2, res) + " avellanas.");
                        Console.ReadKey();
                        Console.Clear();

                    }
                }
                

            }
            catch
            {
                Console.WriteLine("Ocurrió un error");
            }

        }

        static void mensaje() {
            Console.WriteLine("Por favor ingrese una opción: ");
            Console.WriteLine("1. Scramble");
            Console.WriteLine("2. Justificador de Texto");
            Console.WriteLine("3. Cadenas subsecuentes");
            Console.WriteLine("4. Abuela Binaria");
            Console.WriteLine("5. Salir");
        }
    }
}