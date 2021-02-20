using System;

namespace _1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string letra;
            Console.WriteLine("Ingrese una letra");
            letra = Console.ReadLine();
            if (letra == "A" || letra == "B" || letra == "C" || letra == "D" ||
                letra == "E" || letra == "F" || letra == "G" || letra == "H" ||
                letra == "I" || letra == "J" || letra == "K" || letra == "I" ||
                letra == "M" || letra == "N" || letra == "O" || letra == "P" ||
                letra == "Q" || letra == "R" || letra == "S" || letra == "T" ||
                letra == "U" || letra == "V" || letra == "W" || letra == "X" ||
                letra == "Y" || letra == "Z")
            {
                Console.WriteLine("Es mayuscula");
            }
            else
            {
                Console.WriteLine("Es minuscula");
            }

            Console.ReadKey();
        }
    }
}
