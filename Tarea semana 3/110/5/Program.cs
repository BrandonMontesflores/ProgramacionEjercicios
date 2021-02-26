using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double perimetro;
            double area;
            double apotema;
            string valor = "";
            int opcion = 0;
            Console.WriteLine(" 1 - Perimetro");
            Console.WriteLine(" 2 - Area");
            Console.WriteLine("Ingrese un numero para calcular su poligono");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            Console.WriteLine("Ingrese la medida de los lados del poligono");
            valor = Console.ReadLine();
            a = Convert.ToSingle(valor);
            Console.WriteLine("Ingrese cuantos lados tiene el poligono");
            valor = Console.ReadLine();
            b = Convert.ToSingle(valor);
            Console.WriteLine("Ingrese la apotema del poligono");
            valor = Console.ReadLine();
            apotema = Convert.ToSingle(valor);
            perimetro = a * b; 
            area = (perimetro * apotema) / 2;
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("La medida del perimetro es de {0}", perimetro);
                    break;
                case 2:
                    Console.WriteLine("La medida del area es de {0}", area);
                    break;
            }
            Console.ReadKey();
        }
    }

}
