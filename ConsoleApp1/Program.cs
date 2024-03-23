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

            int[] liczbyMax = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 0 };
            int maksimum = ZnajdzMaksimum(liczbyMax);
            Console.WriteLine($"Maksymalna wartość: {maksimum}");

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

        public static int ZnajdzMaksimum(int[] liczbyMaxPrzedZmiana)
        {
            if (liczbyMaxPrzedZmiana == null || liczbyMaxPrzedZmiana.Length == 0)
            {
                throw new ArgumentException("Tablica nie może być null lub pusta.");
            }

            int maks = liczbyMaxPrzedZmiana[0];
            foreach (int liczba in liczbyMaxPrzedZmiana)
            {
                if (liczba > maks)
                {
                    maks = liczba;
                }
            }

            return maks;
        }

    }
}


