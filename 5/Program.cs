using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            Console.WriteLine("Ingrese un dia de la semana");
            dia = Console.ReadLine();
            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("Dia laboral");
                    break;
                case "martes":
                    Console.WriteLine("Dia laboral");
                    break;
                case "miercoles":
                    Console.WriteLine("Dia laboral");
                    break;
                case "jueves":
                    Console.WriteLine("Dia laboral");
                    break;
                case "viernes":
                    Console.WriteLine("Dia laboral");
                    break;
                case "sabado":
                    Console.WriteLine("Dia laboral");
                    break;
                case "domingo":
                    Console.WriteLine("¡Es dia de descanso, disfruta!");
                    break;
            }

        }
    }
}
