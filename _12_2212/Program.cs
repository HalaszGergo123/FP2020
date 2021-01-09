using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2212
{
    class Program
    {//Matrici
        static void Main(string[] args)
        {
            
            int[] v = new int[10]; // tablou undimensional sau vector

            //tablou bidimensionale sau matrice

            int[,] matrice = new int[3, 4];
            int[,,] x = new int[2, 3, 4]; //tablou tridimensional

            int[,] a = CreateMatrix(3,4);
            PrintMatrix(a);
            Console.WriteLine();
            int[,] b = CreateMatrix(4, 5);
            PrintMatrix(b);
            Console.WriteLine();
            int[,] c = MatrixMultiply(a, b);
            PrintMatrix(c);

            // Matrici patratice = numarul liniilor este egal cu numarul coloanelor

        }
        /// <summary>
        /// Inmulteste doua matrici
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>rezultatul inmultirii</returns>
        /// <example>
        /// 1 2  x 3 4 5 = 7
        /// 3 4    2 3 6
        /// secundar = p[i,n-1-i]
        /// main p[i,i]
        /// </example>
        private static int[,] MatrixMultiply(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0))
            {
                //matricile nu pot fi inmultite
                throw new InvalidOperationException();
            }
            int[,] p = new int[a.GetLength(0), b.GetLength(1)];
            int suma;
            for (int i = 0; i < p.GetLength(0); i++)
            {
                for (int j = 0; j < p.GetLength(1); j++)
                {
                    suma = 0;
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        suma += a[i, k]  * b[k, j];
                    }
                    p[i, j] = suma;
                }
            }
            return p;
        }

        /// <summary>
        /// Creaza o matrice si initializeaza elementele la valori 
        /// </summary>
        /// <param name="linii"></param>
        /// <param name="coloane"></param>
        /// <returns></returns>
        private static int[,] CreateMatrix(int linii, int coloane)
        {
            int[,] mat = new int[linii, coloane];
            Random rnd = new Random();
            
            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j <mat.GetLength(1); j++)
                    mat[i, j] = rnd.Next(-10, 10);

           
            return mat;

        }

        private static void PrintMatrix(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i,j],4} "); //mat[i][j] sintaxa C,C++
                }
                Console.WriteLine();
            }
        }
    }
}
