using System;
using System.Threading;

namespace ej1
{
    class Program
    {
        public static string fun(string parametro, int startindex, int length)
        {
            string total = parametro.Substring(startindex, length);
            return total;
        }

        static void Main(string[] args)
        {
            string nombre;
            string ope;
            int valor1 = 0;
            int valor2 = 0;
            int valor3 = 0;
            int valor4 = 0;
            Console.Write("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.SetCursorPosition(3, 6);
            Console.Write(nombre);
            valor3 = nombre.Length;
            valor4 = 75;
            nombre = nombre.ToUpper();
            for (valor2 = nombre.Length; valor2 >=1; valor2--) 
            {
                ope = fun(nombre, valor2 - 1, 1);
                for (valor1 = valor3; valor1 <= valor4; valor1++) 
                {
                    Console.SetCursorPosition(valor1, 6);
                    Console.Write(" " + ope);
                    Thread.Sleep(25);
                }
                valor4 = valor4 - 1;
                valor3 = valor3 - 1; 
            }
        }
    }
}
