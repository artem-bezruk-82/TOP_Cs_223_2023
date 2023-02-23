//Модуль 2
//Тема: Массивы и строки
//ДОМАШНЕЕ ЗАДАНИЕ

//Задание 2
//Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
//Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.


using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hw_02_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[5,5];
            FillInArray2DRandom(array2D, -100, 100);
            PrintArray2DConsole(array2D);

            int maxRow = 0;
            int maxCol = 0;
            int minRow = 0;
            int minCol = 0;

            for (int i = 0; i < array2D.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array2D.GetUpperBound(1) + 1; j++)
                {
                    if (array2D[maxRow, maxCol] <= array2D[i,j])
                    {
                        maxRow = i;
                        maxCol = j;
                    }

                    if (array2D[minRow, minCol] >= array2D[i, j])
                    {
                        minRow = i;
                        minCol = j;
                    }
                }
            }

            Console.WriteLine($"max: {array2D[maxRow, maxCol]}\nmin: {array2D[minRow, minCol]}");
            Console.WriteLine($"Sum: {SumWithinRangeArray2D(array2D, minRow, minCol, maxRow, maxCol)}");
        }

        static int SumWithinRangeArray2D(int[,] array, int startRow, int startCol, int endRow, int endCol) 
        {
            int sum = 0;

            if (startRow == endRow)
            {
                if (startCol > endCol)
                {
                    (startCol, endCol) = (endCol, startCol);
                }

                for (int j = startCol + 1; j < endCol; j++)
                {
                    sum += array[startRow, j];
                }
            } 
            else 
            {
                if (startRow > endRow)
                {
                    (startRow, endRow) = (endRow, startRow);
                    (startCol, endCol) = (endCol, startCol);
                }

                for (int i = startRow; i <= endRow + 1; i++)
                {
                    if (i == startRow)
                    {
                        for (int j = startCol; j < array.GetUpperBound(1) + 1; j++)
                        {
                            sum += array[i, j];
                        }
                    }

                    if (i > startRow && i < endRow)
                    {
                        for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                        {
                            sum += array[i, j];
                        }
                    }

                    if (i == endRow)
                    {
                        for (int j = 0; j < endCol; j++)
                        {
                            sum += array[i, j];
                        }
                    }

                }
            }
            return sum;
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


    }
}