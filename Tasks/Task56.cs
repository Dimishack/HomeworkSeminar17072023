using System;
using System.Linq;

namespace HomeworkSeminar17072023.Tasks
{
    /*
     * Задача 56: Задайте прямоугольный двумерный массив. 
     * Напишите программу, которая будет находить строку с наименьшей суммой элементов.
     * Например, задан массив:
     * 1 4 7 2
     * 5 9 2 3
     * 8 4 2 4
     * 5 2 6 7
     * Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
     */
    internal class Task56
    {
        internal static void MinSumOfRow()
        {
            var random = new Random();
            string rowsMin = String.Empty;
            var array = new int[random.Next(4, 9), random.Next(4, 9)];
            var sums = new int[array.GetLength(0)];

            Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. " +
                "Напишите программу, которая будет находить строку с наименьшей суммой элементов." +
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
                int sum = 0;

                Console.WriteLine("Сумма чисел {0} строки", i + 1);
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                    Console.Write(array[i, j]);
                    if (j < array.GetLength(1) - 1)
                        Console.Write(" + ");
                }
                sums[i] = sum;
                Console.WriteLine(" = " + sum);
                Console.WriteLine(new string('_', 20));
            }
            for (int i = 0; i < sums.Length;)
            {
                i = Array.IndexOf(sums, sums.Min(), i);
                if (i == -1) break;
                else rowsMin += ++i + " ";
            }
            Console.WriteLine("Номера строк с наименьшей суммой чисел: " + rowsMin);
        }
    }
}
