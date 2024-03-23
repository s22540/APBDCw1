// See https://aka.ms/new-console-template for more information
using System;

namespace SredniaLiczb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = { 1, 2, 3, 4, 5 };
            double srednia = ObliczSrednia(liczby);
            Console.WriteLine($"Średnia: {srednia}");
            Console.WriteLine("Naciśnij dowolny klawisz, aby zamknąć...");
            Console.ReadKey();
        }

        public static double ObliczSrednia(int[] liczby)
        {
            if (liczby == null || liczby.Length == 0)
            {
                throw new ArgumentException("Tablica nie może być null lub pusta.");
            }

            double suma = 0;
            foreach (int liczba in liczby)
            {
                suma += liczba;
            }

            return suma / liczby.Length;

        }

    }
}


