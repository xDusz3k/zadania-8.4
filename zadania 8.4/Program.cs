using System;

namespace zadania_8._4
{
    internal class Program
    {
        /* wyswietlanie tablicy */
        static void printTable(int[] table)
        {
            string txt = "[";
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] == 0)
                {
                    break;
                }
                txt += table[i];
                if (i < table.Length - 1)
                {
                    txt += ", ";
                }
            }
            txt += "]";
            Console.WriteLine(txt);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość ciągu");
            int n = int.Parse(Console.ReadLine());
            string Parzyste = "";
            string NieParzyste = "";
            string PodzielnePrzezTrzy = "";
            string Przedzial = "";
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Parzyste += i  + ", ";
                   
                }
                else
                {
                    NieParzyste += i + ", ";
                }
                if (i % 3 == 0)
                {
                    PodzielnePrzezTrzy += i + ", ";              
                }
                if (i >= 4 && i <15)
                {
                    Przedzial += i + ", ";
                }
            }
            Console.WriteLine("Liczby parzyste:");
            Console.WriteLine(Parzyste);
            Console.WriteLine("Liczby nieparzyste:");
            Console.WriteLine(NieParzyste);
            Console.WriteLine("Liczby, które dzielą się przez 3");
            Console.WriteLine(PodzielnePrzezTrzy);
            Console.WriteLine("Liczby z przedziału [4;15)");
            Console.WriteLine(Przedzial);












            //Console.WriteLine("Podaj długość ciągu");
            //int n = int.Parse(Console.ReadLine());
            //int[] LiczbyParzyste = new int[n];
            //int[] LiczbyNieParzyste = new int[n];
            //int[] LiczbyPodzielnePrzezTrzy = new int[n];
            //int[] LiczbyZPrzedzialu = new int[n];
            //int[] CyfryLiczbParzyste = new int[n];
            //int[] SumaCyfrRownaJeden = new int[n];
            //for (int i = 0; i <= n; i++)
            //{
            //    string liczba = Convert.ToString(i);
            //    bool CyfryParzyste = true;
            //    int SumaCyfr = 0;

            //    for (int ii = 0; ii < liczba.Length; ii++)
            //    {
            //        //int Cyfra = (int)liczba[ii];
            //        SumaCyfr = SumaCyfr + (int)liczba[ii]-48;

            //        if (Convert.ToInt64(liczba[ii]) % 2 != 0)
            //        {
            //            CyfryParzyste = false;
            //        }
            //    }
            //    Console.WriteLine(SumaCyfr);
            //    if (CyfryParzyste)
            //    {
            //        for (int ii = 0; ii < CyfryLiczbParzyste.Length; ii++)
            //        {
            //            if (CyfryLiczbParzyste[ii] == 0)
            //            {
            //                CyfryLiczbParzyste[ii] = i;
            //                break;
            //            }
            //        }
            //    }


            //    for (int ii = 0; ii < liczba.Length; ii++)
            //    {
            //        int Cyfra = liczba[ii];
            //        SumaCyfr = SumaCyfr + (int)Cyfra;
            //        Console.WriteLine($"\n\n{Cyfra} \n\n") ;
            //    }
            //    if (SumaCyfr == 1)
            //    {
            //        for (int ii = 0; ii < SumaCyfrRownaJeden.Length; ii++)
            //        {
            //            if (SumaCyfrRownaJeden[ii] == 0)
            //            {
            //                SumaCyfrRownaJeden[ii] = i;
            //                break;
            //            }
            //        }
            //    }
            //    if (i % 2 == 0)
            //    {
            //        //Console.WriteLine($"Liczba {i} jest parzysta");
            //        //Console.ForegroundColor = ConsoleColor.Green;
            //        for (int ii = 0; ii < LiczbyParzyste.Length; ii++)
            //        {
            //            if (LiczbyParzyste[ii] == 0)
            //            {
            //                LiczbyParzyste[ii] = i;
            //                break;
            //            }
            //        }
            //    }
            //    else if (i % 2 == 1)
            //    {
            //        //Console.WriteLine($"Liczba {i} jest nieparzysta");
            //        //Console.ForegroundColor = ConsoleColor.Red;
            //        for (int ii = 0; ii < LiczbyNieParzyste.Length; ii++)
            //        {
            //            if (LiczbyNieParzyste[ii] == 0)
            //            {
            //                LiczbyNieParzyste[ii] = i;
            //                break;
            //            }
            //        }
            //    }
            //    if (i % 3 == 0)
            //    {
            //        //Console.WriteLine($"Liczba {i} dzieli się przez 3");
            //        for (int ii = 0; ii < LiczbyPodzielnePrzezTrzy.Length; ii++)
            //        {
            //            if (LiczbyPodzielnePrzezTrzy[ii] == 0)
            //            {
            //                LiczbyPodzielnePrzezTrzy[ii] = i;
            //                break;
            //            }
            //        }
            //    }
            //    //else
            //    //{
            //    //    Console.WriteLine($"Liczba {i} nie dzieli się przez 3");
            //    //}
            //    if (i >= 4 && i <= 15)
            //    {
            //        for (int ii = 0; ii < LiczbyZPrzedzialu.Length; ii++)
            //        {
            //            if (LiczbyZPrzedzialu[ii] == 0)
            //            {
            //                LiczbyZPrzedzialu[ii] = i;
            //                break;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("Liczby parzyste");
            //Console.ForegroundColor = ConsoleColor.Red;
            //printTable(LiczbyParzyste);
            //Console.WriteLine("Liczby nie parzyste");
            //Console.ForegroundColor = ConsoleColor.Blue;
            //printTable(LiczbyNieParzyste);
            //Console.WriteLine("Liczby podzielne przez 3");
            //printTable(LiczbyPodzielnePrzezTrzy);
            //Console.WriteLine("Liczby z przedziału [4,15]");
            //printTable(LiczbyZPrzedzialu);
            //Console.WriteLine("Liczby, których cyfry są parzyste");
            //printTable(CyfryLiczbParzyste);
            //Console.WriteLine("Liczby, których cyfry są równe 1");
            //printTable(SumaCyfrRownaJeden);
        }
    }
}