using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Globalization;

namespace _6_1011
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //numaram numere prime
            CountPrimes();
        }
        /// <summary>
        /// Metoda determina num
        /// </summary>
        private static void CountPrimes()
        {
            
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int contorPrime = 0;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for(int nr = a;nr<=b;nr++)
            {
                
                if(nr.IsPrime())
                {
                    contorPrime++;
                }


            }
            sw.Stop();
            DateDiff();
        }

        private static void DateDiff()
        {
            DateTime azi = DateTime.Now;
            CultureInfo.CurrentCulture = new CultureInfo("RO");
            Console.WriteLine(azi.ToString("d MMMM yyyy"));
            azi.Subtract( )
        }
    }
}
