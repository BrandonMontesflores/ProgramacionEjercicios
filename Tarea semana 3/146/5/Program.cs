using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor = 0, menor = 0, num = 0;
            int suma = 0, promedio = 0;
            Console.WriteLine("Ingrese la cantidad de personas");
            int num1 = int.Parse(Console.ReadLine());
        
            for (int i = 1; i <= num1; i++)
            {
                Console.WriteLine("Escriba la edad");
                num = int.Parse(Console.ReadLine());
                suma = suma + num;
                promedio = suma / num1;
                if (i == 1)
                {
                    mayor = num;
                    menor = num;
                }
                if (num > mayor)
                {
                    mayor = num;
                }
                if (num < menor)
                {
                    menor = num;
                }
                num = 0;
            }
            Console.WriteLine("La edad mayor es {0}",mayor);
            Console.WriteLine("La edad menor es {0}",menor);
            Console.WriteLine("El promedio de edad es {0}", promedio);
            Console.ReadKey();
        }
            
    }
}
