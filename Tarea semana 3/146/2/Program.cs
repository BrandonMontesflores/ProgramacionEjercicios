using System;

namespace _2
{
    class Program
    {
        static int pot(int bas, int exp)
        {
            int valor = 1;
            int i;
            for (i = 1; i <= exp; i++)
                valor *= bas;
            return valor;
        }
        static void Main()
        {
        int num1, num2;
            Console.WriteLine("Ingrese la base");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} con potencia de {1} es igual a {2}", num1, num2, pot(num1, num2));
            Console.ReadKey();
        }
    }
}
