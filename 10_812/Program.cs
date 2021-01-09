using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_812
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            /*
            for (int i = 0; i < 100; i++)
            {
               // System.Threading.Thread.Sleep(50);
                int[] arr = InitArray(8, 0, 100, rnd);
                PrintArray(arr); 
            }
          */
            int noOfValuesToSort = 100000;
            int maxValue = 100;

            int[] arr = InitArray(noOfValuesToSort, 0, 100, rnd);

            CountingSort(arr, maxValue);
           
        }

        private static void CountingSort(int[] arr, int maxValue)
        {
           
        }

        /// <summary>
        /// Bubble sort
        /// swapped = false;
        /// </summary>
        /// <param name="arr"></param>
        private static void BubbleSort(int[] arr)
        {
            bool swapped;
            for (int i = 0; i < arr.Length; i++)
            {
                swapped = false;
                for (int j = arr.Length-1; j > i ; j--)
                {
                    if (arr[j] < arr[j-1])
                    {
                        int aux;
                        aux = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = aux;
                        swapped = true; 

                    }
                    
                }
                if (!swapped)
                    break;
            }           
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

        private static int[] InitArray(int length, int min, int max, Random rnd)
        {
            int[] v = new int[length];
          
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(min, max);

            }
            return v;
        }
    }
}
