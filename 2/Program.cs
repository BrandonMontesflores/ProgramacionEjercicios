using System;

namespace _2
{
    class Program
    {
        public static void Main(string[] args)
        {
            double compra; 
            double total;
            const double descuento = 0.20;

            Console.WriteLine("Ingrese la compra \t");
            compra = Convert.ToDouble(Console.ReadLine());

            if (compra >= 300)
            { total = (compra * descuento);
                Console.Write("Total con descuento \t" + (compra - total));
            }
            else
                Console.Write("Total \t" + (compra));
            Console.ReadKey();
        }
    }
}
