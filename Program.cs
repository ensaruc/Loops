using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] f1Takimlari = new string[] { "Mercedes", "Red Bull", "Ferrari" };

            for (int i = 0; i < f1Takimlari.Length; i++)
            {
                Console.WriteLine(f1Takimlari[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string f1Takim in f1Takimlari)
            {
                Console.WriteLine(f1Takim);
            }


            for (int i = 1; i < 10; i=i+1)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
