//ДОМАШНЕЕ ЗАДАНИЕ
//Тема: Top level statements. Введение в классы. Обработка исключений
//Модуль 3. Часть 1

//Задание 3
//Напишите метод, фильтрующий массив на основании переданных параметров.
//Метод принимает параметры: оригинальный_массив, массив_с_данными_для_фильтрации.
//Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
//Например:
//[1 2 6 -1 88 7 6] — оригинальный массив;
//[6 88 7] — массив для фильтрации;
//[1 2 - 1] — результат работы метода.

namespace hw_03_p1_task3_ArrayFiltering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray1 = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filteringArray = { 6, 88, 7 };
            Console.WriteLine($"{nameof(originalArray1)}\n{string.Join(' ', originalArray1)}");
            Console.WriteLine($"{nameof(filteringArray)}\n{string.Join(' ', filteringArray)}");
            FilterOutValues(ref originalArray1, filteringArray);
            Console.WriteLine($"Final array:\n{string.Join(' ', originalArray1)}");
        }

        static void FilterOutValues(ref int[] array, int[] filteringValues) 
        {
            for (int i = 0; i < filteringValues.Length; i++)
            {
                int? indexArray = null;
                while (indexArray != -1) 
                {
                    indexArray = Array.IndexOf(array, filteringValues[i]);
                    if (indexArray != -1) 
                    {
                        RemoveElement(ref array, indexArray);
                    }
                }
            }
        }

        static void RemoveElement(ref int[] array, int? index) 
        {
            int[] temp = new int[array.Length - 1];
            int tempIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != index) 
                {
                    temp[tempIndex] = array[i];
                    tempIndex++;
                }
            }
            array = temp;
        }
    }
}