using System;

namespace _3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int horas, horasx;
            double total, total1, salario;
            Console.WriteLine("Ingrese el total de sus horas");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese sus horas extras");
            horasx = int.Parse(Console.ReadLine());
            total = (horas - horasx) *(16);
            total1 = horasx * 20;
            salario = total + total1;
            if (horas <= 40)
            {
                Console.Write("Salario total \t" + total);
            }
            else if (horas > 40)
            {
                Console.Write("Salario total con horas extras \t" + salario);
            }
            Console.ReadKey();
        }
    }
}
