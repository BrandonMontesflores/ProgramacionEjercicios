using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            if ((num % 2) == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
                Console.ReadKey();
        }
    }
}
