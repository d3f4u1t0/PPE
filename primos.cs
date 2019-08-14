using System;

namespace Plataformas_de_programación_empresarial
{
    class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {

            int a = 0;
            int i;
            int n;
            Console.WriteLine("Ingrese un numero");
            n = Convert.ToInt32(Console.ReadLine);
            for (i = 0; i <= (n + 1); i++)
            {
                if (n % i == 0)
                {
                    a++;
                }

                if (a != 2)
                {
                    Console.WriteLine("No es primo");
                }
                else
                {
                    Console.WriteLine("Si es primo");
                }
                Console.ReadLine();

            }
        }
    }
}

