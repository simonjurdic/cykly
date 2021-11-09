using System;

namespace cykly
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 varianta
            int cislo = 1;

            while(cislo < 100)
            {
                Console.WriteLine(cislo);
                cislo++;
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
