using System;

namespace HomeworkSeminar17072023.Tasks
{
    /*
     * Задача 54: Задайте двумерный массив. 
     * Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
     * Например, задан массив:
     * 1 4 7 2
     * 5 9 2 3
     * 8 4 2 4
     * В итоге получается вот такой массив:
     * 7 4 2 1
     * 9 5 3 2
     * 8 4 4 2
     */
    internal class Task54
    {
        internal static void SortInDescending()
        {
            var random = new Random();
            var array = new int[random.Next(4, 10), random.Next(4, 10)];

            Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, " +
                "которая упорядочит по убыванию элементы каждой строки двумерного массива." +
                "\n" + new string('-', 30));
            Console.WriteLine("Двумерный массив целых чисел (от 1 по 20)");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 21);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int index = j;
                    for (int k = j; k < array.GetLength(1); k++)
                    {
                        if (array[i, index] < array[i, k])
                            index = k;
                    }
                    (array[i, index], array[i, j]) = (array[i, j], array[i, index]);
                }
            }
            Console.WriteLine("\nМассив после сортировки строк по убыванию");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
