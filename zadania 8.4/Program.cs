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
            string SumaCyfr = "";


            for (int i = 0; i <= n; i++)
            {
                int Suma = 0;
                if (i % 2 == 0)
                {
                    Parzyste += i + ", ";

                }
                else
                {
                    NieParzyste += i + ", ";
                }
                if (i % 3 == 0)
                {
                    PodzielnePrzezTrzy += i + ", ";
                }
                if (i >= 4 && i < 15)
                {
                    Przedzial += i + ", ";
                }
                int a = i;
                while (a > 0)
                {
                    Suma += a % 10;
                    a /= 10;


                }
                if (Suma == 1)
                {
                    SumaCyfr += i + ", ";

                }
                //if (i % 10 == 0)
                //{
                //    //i /= 10;
                //    if (i == 1)
                //    {
                //        SumaCyfr += i;
                //    }
                //}


            }
            Console.WriteLine("Liczby parzyste:\n");
            Console.WriteLine($"{Parzyste}\n\n");
            Console.WriteLine("Liczby nieparzyste:\n");
            Console.WriteLine($"{NieParzyste}\n\n");
            Console.WriteLine("Liczby, które dzielą się przez 3:\n");
            Console.WriteLine($"{PodzielnePrzezTrzy}\n\n");
            Console.WriteLine("Liczby z przedziału [4;15):\n");
            Console.WriteLine($"{Przedzial}\n\n");
            Console.WriteLine("Liczby, których suma cyfr wynosi 1:\n");
            Console.WriteLine($"{SumaCyfr}\n\n");












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


//namespace Projekt_INTEL8086
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] numbers = { "2", "3", "10", "5", "3", "7" };
//            int dlugoscTablicy = numbers.Length;
//            for (int indexOfElement = 0; indexOfElement < dlugoscTablicy; indexOfElement++)
//            {
//                int suma;
//                string ELEMENT = numbers[indexOfElement];
//                int iloscLiterek = ELEMENT.Length;
//                for (int indexOfChar = 0; indexOfChar < iloscLiterek; indexOfChar++)
//                {
//                    suma
//                    char LITERKA = ELEMENT[indexOfChar];
//                    Console.WriteLine("ELEMENT:" + ELEMENT);

//                }

//            }

//        }
//    }
//}