//Тема: Массивы и строки
//Модуль 2

//ДОМАШНЕЕ ЗАДАНИЕ

//Задание 4
//Создайте приложение, которое производит операции над матрицами:
//Умножение матрицы на число;
//Сложение матриц;
//Произведение матриц.


using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hw_02_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D_A = new int[5,5];
            FillInArray2DRandom(array2D_A, 1, 20);
            Console.WriteLine($"\n{nameof(array2D_A)}:");
            PrintArray2DConsole(array2D_A);

            int multiplier = 10;
            int[,] array2D_B = MultiplyArray2DByNumber(array2D_A, multiplier);
            Console.WriteLine($"\n{nameof(array2D_A)} * {multiplier}:");
            PrintArray2DConsole(array2D_B);

            int[,] array2D_C = GetSum2DArray(array2D_A, array2D_B);
            Console.WriteLine($"\n{nameof(array2D_A)} + {nameof(array2D_B)}:");
            PrintArray2DConsole(array2D_C);

            int[,] array2D_D = GetProduct2DArray(array2D_A, array2D_B);
            Console.WriteLine($"\n{nameof(array2D_A)} * {nameof(array2D_B)}:");
            PrintArray2DConsole(array2D_D);
        }

        static int[,] GetSum2DArray(int[,] arrayA, int[,] arrayB)
        {
            if (arrayA.GetUpperBound(0) != arrayB.GetUpperBound(0) &&
                arrayA.GetUpperBound(1) != arrayB.GetUpperBound(1))
            {
                throw new ArgumentException(message: "The arrays must be equal-sized");
            }
            int[,] sumArr2D = new int[arrayA.GetUpperBound(0) + 1, arrayA.GetUpperBound(1) + 1];

            for (int i = 0; i < sumArr2D.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < sumArr2D.GetUpperBound(1) + 1; j++)
                {
                    sumArr2D[i, j] = arrayA[i, j] + arrayB[i, j];
                }
            }

            return sumArr2D;
        }

        static int[,] GetProduct2DArray(int[,] arrayA, int[,] arrayB)
        {
            if (arrayA.GetUpperBound(0) != arrayB.GetUpperBound(0) &&
                arrayA.GetUpperBound(1) != arrayB.GetUpperBound(1))
            {
                throw new ArgumentException(message: "The arrays must be equal-sized");
            }
            int[,] productArr2D = new int[arrayA.GetUpperBound(0) + 1, arrayA.GetUpperBound(1) + 1];

            for (int i = 0; i < productArr2D.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < productArr2D.GetUpperBound(1) + 1; j++)
                {
                    productArr2D[i, j] = arrayA[i, j] * arrayB[i, j];
                }
            }

            return productArr2D;
        }

        static int[,] MultiplyArray2DByNumber(int[,] array, int number) 
        {
            int[,] output = new int[array.GetUpperBound(0) + 1, array.GetUpperBound(1) + 1];
            for (int i = 0; i < output.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < output.GetUpperBound(1) + 1; j++)
                {
                    output[i, j] = array[i,j] * number;
                }
            }
            return output;
        }

        static void FillInArray2DRandom(int[,] array, int startRange, int endRange) 
        {
            Random random = new Random();
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    array[i, j] = random.Next(startRange, endRange + 1);
                }
            }
        }

        static void PrintArray2DConsole(int[,] array) 
        {
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}