using System;

namespace zadania_8._4
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Podaj długość ciągu");
            int n = int.Parse(Console.ReadLine());
            int[] LiczbyParzyste = new int[n];
            int[] LiczbyNieParzyste = new int[n];
            int[] LiczbyPodzielnePrzezTrzy = new int[n];
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    //Console.WriteLine($"Liczba {i} jest parzysta");
                    //Console.ForegroundColor = ConsoleColor.Green;
                    for (int ii = 0; ii < LiczbyParzyste.Length; ii++)
                    {
                        if (LiczbyParzyste[ii] == null)
                        {
                            LiczbyParzyste[ii] = i;
                            break;
                        }
                    }
                }
                else if (i % 2 == 1)
                {
                    //Console.WriteLine($"Liczba {i} jest nieparzysta");
                    //Console.ForegroundColor = ConsoleColor.Red;
                    for (int ii = 0; ii < LiczbyNieParzyste.Length; ii++)
                    {
                        if (LiczbyNieParzyste[ii] == null)
                        {
                            LiczbyNieParzyste[ii] = i;
                            break;
                        }
                    }
                }
                if (i % 3 == 0)
                {
                    //Console.WriteLine($"Liczba {i} dzieli się przez 3");
                    for (int ii = 0; ii < LiczbyPodzielnePrzezTrzy.Length; ii++)
                    {
                        if (LiczbyPodzielnePrzezTrzy[ii] == null)
                        {
                            LiczbyPodzielnePrzezTrzy[ii] = i;
                            break;
                        }
                    }
                }
                //else
                //{
                //    Console.WriteLine($"Liczba {i} nie dzieli się przez 3");
                //}
                //if (i >= 4 && i <= 15)
                //{
                //    Console.WriteLine(i);
                //}
            }
            for (int ii = 0; ii < LiczbyParzyste.Length; ii++)
            {
                if (LiczbyParzyste[ii] == null)
                {
                    break;
                }
                Console.WriteLine(LiczbyParzyste[ii]);
            }
        }
    }
}