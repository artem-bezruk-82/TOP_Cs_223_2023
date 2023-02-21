//Модуль 2
//Тема: Массивы и строки
//ДОМАШНЕЕ ЗАДАНИЕ

//Задание 1

//Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B.
//Заполнить одномерный массив А числами, введенными с клавиатуры пользователем,
//а двумерный массив В случайными числами с помощью циклов.
//Вывести на экран значения массивов:
//массива А в одну строку,
//массива В — в виде матрицы.
//Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов,
//общее произведение всех элементов,
//сумму четных элементов массива А,
//сумму нечетных столбцов массива В.

using System;

namespace hw_02_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array1D = new double[5];
            double[,] array2D = new double[3, 4];

            FillInArray1DConsole(array1D);
            FillInArray2DRandom(array2D);

            Console.WriteLine($"{string.Join(' ', array1D)}\n");
            PrintArray2DConsole(array2D);

            Console.WriteLine($"Sum: {array1D.Sum() + GetSumArray2D(array2D)}");
            Console.WriteLine($"Product: {GetProductArray1D(array1D) * GetProductArray2D(array2D)}");

            double maxElement1D = array1D.Max();
            double maxElement2D = GetMaxArray2D(array2D);
            Console.WriteLine($"Max: {(maxElement1D > maxElement2D ? maxElement1D : maxElement2D)}");

            double minElement1D = array1D.Min();
            double minElement2D = GetMinArray2D(array2D);
            Console.WriteLine($"Min: {(minElement1D < minElement2D ? minElement1D : minElement2D)}");

            Console.WriteLine($"Sum of evens in array 1D: {GetSumOfEvens1D(array1D)}");

            Console.WriteLine($"Sum of odd columns in array 2D: {GetSumOfOddColumns2D(array2D)}");

        }

        static double GetSumOfOddColumns2D(double[,] array) 
        {
            double sum = 0;

            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    if (j % 2 != 0)
                    {
                        sum += array[i, j];
                    }
                }
            }

            return sum;
        }

        static double GetSumOfEvens1D(double[] array)
        {
            double sumOfEvens = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumOfEvens += array[i];
                }
            }
            return sumOfEvens;
        }

        static double GetMaxArray2D(double[,] array) 
        {
            double max = array[0, 0];
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }

        static double GetMinArray2D(double[,] array)
        {
            double min = array[0, 0];
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }

        static double GetProductArray1D(double[] array) 
        {
            double product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }

        static double GetProductArray2D(double[,] array)
        {
            double product = 1;
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    product *= array[i, j];
                }
            }
            return product;
        }

        static double GetSumArray2D(double[,] array) 
        {
            double sum = 0;
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    sum += array[i, j];
                }
            }
            return sum;
        }

        static void PrintArray2DConsole(double[,] array) 
        {
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    Console.Write($"{array[i,j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void FillInArray2DRandom(double[,] array) 
        {
            Random random = new Random();
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) +1; j++)
                {
                    array[i,j] = Math.Round(random.NextDouble() * 100, 1);
                }
            }
        }

        static void FillInArray1DConsole(double[] array) 
        {
            Console.WriteLine($"Please fill in 1D array with {typeof(double)} elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GetConsoleInput($"Please enter {i} array element out of {array.Length}");
            }
        }

        static double GetConsoleInput(string requestText)
        {
            double? value = null;

            while (value is null)
            {
                Console.WriteLine(requestText);
                try
                {
                    value = double.Parse(Console.ReadLine() ?? "");
                }
                catch (Exception exc)
                {

                    Console.WriteLine($"{exc.Message} Please enter {typeof(double)} value");
                }
            }
            return (double)value;
        }

    }
}