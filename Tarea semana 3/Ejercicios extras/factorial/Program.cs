using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int num1 = 0;
            int factorial = 1;
            string valor = "";
            Console.WriteLine("Ingrese el numero que desea");
            valor = Console.ReadLine();
            num1 = Convert.ToInt32(valor);
            for (num = num1; num >= 1; num --) 
                factorial *= num;
            Console.WriteLine("El factorial de {0} es {1}", num1, factorial);
        }
    }
}
