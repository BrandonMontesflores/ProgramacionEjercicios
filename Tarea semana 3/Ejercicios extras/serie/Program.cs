using System;

namespace serie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, num;
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            a = 0;
            b = 1;
            for (int i = 0; i < num; i++)
            { 
                    c = a;
                    a = b;
                    b = c + a;
                    Console.Write(" {0} ", a);
            }
            Console.ReadKey();
        }
    }
}
