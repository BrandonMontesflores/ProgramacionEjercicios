
using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Febrero = 2;
            const int Diciembre = 12;
            int daysInFebrero = System.DateTime.DaysInMonth(2005, Febrero);
            Console.WriteLine(daysInFebrero);

            int daysInDiciembre = System.DateTime.DaysInMonth(2020, Diciembre);
            Console.WriteLine(daysInDiciembre);

            int daysInFebreroLeap = System.DateTime.DaysInMonth(1996, Febrero);
            Console.WriteLine(daysInFebreroLeap);

        }
    }
}
