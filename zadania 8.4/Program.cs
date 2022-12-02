using System;
using System.Data;

namespace zadania_8._4
{
    internal class Program
    {
        /* wyswietlanie tablicy */
        //static void printTable(int[] table)
        //{
        //    string txt = "[";
        //    for (int i = 0; i < table.Length; i++)
        //    {
        //        if (table[i] == 0)
        //        {
        //            break;
        //        }
        //        txt += table[i];
        //        if (i < table.Length - 1)
        //        {
        //            txt += ", ";
        //        }
        //    }
        //    txt += "]";
        //    Console.WriteLine(txt);
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość ciągu");
            int n = int.Parse(Console.ReadLine());
            int[] tablica = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbe");
                int temp = int.Parse(Console.ReadLine());
                tablica[i] = temp;
            }
            int[] Parzyste = new int[n];
            int liczbaParzystych = 0;
            int[] NieParzyste = new int[n];
            int liczbaNieParzystych = 0;
            int[] PodzielnePrzezTrzy = new int[n];
            int liczbaPodzielnychPrzezTrzy = 0;
            int[] Przedzial = new int[n];
            int liczbaPrzedzial = 0;
            int[] Cyfry = new int[n];
            int liczbaCyfr = 0;
            int[] SumaCyfr = new int[n];
            int liczbaSumyCyfr = 0;
            int[] DodanieSto = new int[n];
            int liczbaSto = 0;
            int[] Ujemne = new int[n];
            int liczbaUjemne = 0;


            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] % 2 == 0)
                {
                    Parzyste[liczbaParzystych] = tablica[i];
                    liczbaParzystych++;
                }
                else
                {
                    NieParzyste[liczbaNieParzystych] = tablica[i];
                    liczbaNieParzystych++;
                }
                if (tablica[i] % 3 == 0)
                {
                    PodzielnePrzezTrzy[liczbaPodzielnychPrzezTrzy] = tablica[i];
                    liczbaPodzielnychPrzezTrzy++;
                }
                if (tablica[i] >= 4 && tablica[i] < 15)
                {
                    Przedzial[liczbaPrzedzial] = tablica[i];
                    liczbaPrzedzial++;
                }
                int a = tablica[i];
                while (a != 0)
                {
                    int b = a % 10;
                    if (b % 2 != 0)
                    {
                        break;
                    }
                    a /= 10;
                    if (a == 0)
                    {
                        Cyfry[liczbaCyfr] = tablica[i];
                        liczbaCyfr++;
                    }
                }
                a = tablica[i];
                int Suma = 0;
                while (a > 0)
                {
                    Suma += a % 10;
                    a /= 10;
                }
                if (Suma == 1)
                {
                    SumaCyfr[liczbaSumyCyfr] = tablica[i];
                    liczbaSumyCyfr++;
                }
                if (tablica[i] % 2 == 0)
                {
                    DodanieSto[liczbaSto] = tablica[i] + 100;
                    liczbaSto++;
                }
                if (tablica[i] < 0)
                {
                    tablica[i] = 0;
                    Ujemne[liczbaUjemne] = tablica[i];
                    liczbaUjemne++;
                }
                else
                {
                    Ujemne[liczbaUjemne] = tablica[i];
                    liczbaUjemne++;
                }


            }


            Console.WriteLine("Liczby parzyste");
            for (int i = 0; i < liczbaParzystych; i++)
            {
                Console.Write($"{Parzyste[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine("Liczby nieparzyste");
            for (int i = 0; i < liczbaNieParzystych; i++)
            {
                Console.Write($"{NieParzyste[i]}, ");
            }

            Console.WriteLine();
            Console.WriteLine("Liczby podzielne przez 3");
            for (int i = 0; i < liczbaPodzielnychPrzezTrzy; i++)
            {
                Console.Write($"{PodzielnePrzezTrzy[i]}, ");
            }

            Console.WriteLine();
            Console.WriteLine("Liczby z przedziału [4;15)");
            for (int i = 0; i < liczbaPrzedzial; i++)
            {
                Console.Write($"{Przedzial[i]}, ");
            }

            Console.WriteLine();
            Console.WriteLine("Liczby, ktore mają wszystkie cyfry parzyste");
            for (int i = 0; i < liczbaCyfr; i++)
            {
                Console.Write($"{Cyfry[i]}, ");
            }

            Console.WriteLine();
            Console.WriteLine("Liczby, których suma cyfr wynosi 1");
            for (int i = 0; i < liczbaSumyCyfr; i++)
            {
                Console.Write($"{SumaCyfr[i]}, ");
            }

            Console.WriteLine();
            Console.WriteLine("Liczby po dodaniu do nich 100");
            for (int i = 0; i < liczbaSto; i++)
            {
                Console.Write($"{DodanieSto[i]}, ");
            }

            Console.WriteLine();
            Console.WriteLine("Ciąg liczb, w którym liczby ujemne zamieniane są na 0");
            for (int i = 0; i < liczbaUjemne; i++)
            {
                Console.Write($"{Ujemne[i]}, ");
            }
        }
    }
}



