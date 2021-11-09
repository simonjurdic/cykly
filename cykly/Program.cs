using System;

namespace cykly
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 varianta (sudá čísla)
            int cislo = 2;

            while(cislo < 100)
            {
                Console.WriteLine(cislo);
                cislo+=2;
            }
            Console.ReadLine();

            // 2 varianta
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i);

            }
            Console.ReadLine();
            

        }  
    }
}
