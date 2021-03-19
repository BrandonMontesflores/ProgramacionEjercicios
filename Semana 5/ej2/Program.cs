using System;
using System.Threading;

namespace ej2
{
    class Program
    {
        public static void dibujar(int total)
        {
            int valor1 = 15;
            int valor2 = 50;
            int valor3 = 5;
            int valor4 = 5;
            int valor5, valor6, valor7;
            for (valor7 = 1; valor7 <= total; valor7++)
            {
                for (valor5 = valor4; valor5 <= valor2; valor5++)
                {
                    Console.SetCursorPosition(valor5, valor1); Console.Write("A");
                    Console.SetCursorPosition(valor5, valor3); Console.Write("A");
                }
                for (valor6 = valor3; valor6 <= valor1; valor6++)
                {
                    Console.SetCursorPosition(valor4, valor6); Console.Write("a");
                    Console.SetCursorPosition(valor2, valor6); Console.Write("a");
                }
                valor3 = valor3 + 1;
                valor1 = valor1 - 1;
                valor4 = valor4 + 1;
                valor2 = valor2 - 1;
            }
        }

        static void Main(string[] args)
        {
            for (int total2 = 1; total2 < 3; total2++)
            {
                dibujar(total2);
                Thread.Sleep(100);
            }
        }

    }
}
