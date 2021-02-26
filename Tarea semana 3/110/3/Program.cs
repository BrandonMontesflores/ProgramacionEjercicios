using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0f;
            double resultado = 0.0f;
            string valor = "";
            int opcion = 0;
            Console.WriteLine(" 1 - Comida");
            Console.WriteLine(" 2 - Ropa");
            Console.WriteLine(" 3 - Medicina");
            Console.WriteLine("Ingrese una opcion para conocer su impuesto");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            Console.WriteLine("Ingrese el valor del producto");
            valor = Console.ReadLine();
            a = Convert.ToSingle(valor);
            switch (opcion)
            {
                case 1:
                    resultado = a * 0.12;
                    break;
                case 2:
                    resultado = a * 0.12;
                    break;
                case 3:
                    resultado = a * 0;
                    break;
            }
            Console.WriteLine("El impuesto es de {0}", resultado);
            Console.ReadKey();
        }
    }
}
