 using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0f;
            double resultado = 0.0f;
            string valor = "";
            int opcion = 0;
            Console.WriteLine(" 1 - Grados a radianes");
            Console.WriteLine(" 2 - Radianes a grados");
            Console.WriteLine("Ingrese una opcion");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            Console.WriteLine("Ingrese los grados");
            valor = Console.ReadLine();
            a = Convert.ToSingle(valor);
            switch (opcion)
            {
                case 1:
                    resultado = a * (Math.PI / 180);
                    break;
                case 2:
                    resultado = a * (180 / Math.PI);
                    break;
            }
            Console.WriteLine("El resultado es {0}", resultado);
            Console.ReadKey();
        }
    }
}
