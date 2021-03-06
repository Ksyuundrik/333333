﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verify2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            int n = 4;
            float[,] A = new float[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            A = matrix.TranspositionMatrix(A, n);
            Console.WriteLine("Транспонированная матрица.");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("\n[" + (i + 1) + ", " + (j + 1) + "] = " + A[i, j]);
                }
            }

            bool c = matrix.Symmetry(A, n);
            if (c) Console.WriteLine("Матрица симметрична.");
            else Console.WriteLine("Матрица несимметрична.");
            float[,] C = new float[n, n];
            int k=2;
            C = matrix.MultiplyMatrixOnNumber(A, k, n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("\n[" + (i + 1) + ", " + (j + 1) + "] = " + C[i, j]);
                }
            }

            float[,] B = new float[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            C = matrix.AdditionTwoMatrix(A, B, n);
            Console.WriteLine("Результат сложения 2-х матриц.");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("\n[" + (i + 1) + ", " + (j + 1) + "] = " + C[i, j]);
                }
            }


            C = matrix.MultiplyTwoMatrix(A, B, n);

            Console.WriteLine("Результат перемножения 2-х матриц.");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("\n[" + (i + 1) + ", " + (j + 1) + "] = " + C[i, j]);
                }
            }
        }
    }
}
