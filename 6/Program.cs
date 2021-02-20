using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, N;
            Console.WriteLine("Ingrese el numero");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < (N + 1); i++)
            {
                if (N % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine("No es primo");
            }
            else
            {
                Console.WriteLine("Es primo");
            }
            Console.ReadLine();

        }
    }
}
