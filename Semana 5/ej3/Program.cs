using System;

namespace ej3
{
    class Program
    {
        public static string letrac(int min, int max)
        {
            Random rango = new Random();
            int numero = Convert.ToInt32(rango.Next(97,122));
            string respuesta = "";
            if (((numero > min) & (numero < max)))
            {
                    respuesta = Convert.ToString((char)numero);
            }
            return  respuesta;
        }

        static void Main(string[] args)
        {
            byte valor1, valor2;
            
            string valor;
            Console.WriteLine("Ingrese cuantos valores desea");
            valor = Console.ReadLine();
            valor1 = byte.Parse(valor);

            string letrasn = "";
            for (valor2=1; valor2<=valor1; valor2++)
            {
                
                
                {
                    letrasn = letrasn + letrac(0,255);

                }
                    Console.WriteLine($"Valores generados= {letrasn}");
            }

        }
    }
}
