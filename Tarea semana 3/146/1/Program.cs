using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Ingrese el numero de la tabla que desea");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + "x" + i + "=" +(i * num));
            }
            Console.ReadKey();
        }
    }
}
