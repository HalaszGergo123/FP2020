using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2311
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = InitArray(8,0,100);
            Console.WriteLine("Before...");
            PrintArray(arr);
            Array.Sort(arr);
            


            Console.WriteLine("After...");
            PrintArray(arr);
        }

        private static void PrintArray(int[] arr)
        {
            //iteratia read-only 
            foreach (int item in arr)
            {
                Console.Write($"{item} ");

            }
            Console.WriteLine();
        }

        private static int[] InitArray(int length,int min,int max)
        {
            int[] v = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(min, max);

            }
            return v;
        }
       
    }
}
