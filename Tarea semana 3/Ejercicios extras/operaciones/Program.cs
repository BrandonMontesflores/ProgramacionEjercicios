using System;

namespace operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0.0f;
            float b = 0.0f;
            float resultado = 0.0f;
            string valor = "";
            int opcion = 0;
            do
            {
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - División");
                Console.WriteLine("4 - Multiplicación");
                Console.WriteLine("5 - Salir");
                Console.Write("Que operación deseas hacer: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);
                if (opcion != 5)
                {
                    Console.Write("Dame el primer numero:");
                    valor = Console.ReadLine();
                    a = Convert.ToSingle(valor);

                    Console.Write("Dame el segundo numero:");
                    valor = Console.ReadLine();
                    b = Convert.ToSingle(valor);

                    switch (opcion)
                    {

                        case 1:
                            resultado = a + b;
                            break;

                        case 2:
                            resultado = a - b;
                            break;

                        case 3:
                            if (b != 0)
                                resultado = a / b;
                            else
                                Console.WriteLine("Divisor no valido");
                            break;

                        case 4:
                            resultado = a * b;
                            break;

                        default:
                            Console.WriteLine("Opción no valida");
                            break;
                    }
                    Console.WriteLine("El resultado es: {0}", resultado);
                }
            } 
            while (opcion != 5);
                
        }
    }
}
