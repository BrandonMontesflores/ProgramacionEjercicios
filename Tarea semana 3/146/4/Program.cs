using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 1; i <= 1000; i++)
            {
                for (int a = 1; a <= i; a++)
                {
                    if (i % a == 0)
                    {
                        num = num + 1;
                    }
                }
                if (num <= 2)
                {
                    Console.WriteLine(i);
                }
                num = 0;
            }
            Console.ReadKey();
        }
    }
}
