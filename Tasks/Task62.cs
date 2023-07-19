using System;

namespace HomeworkSeminar17072023.Tasks
{
    /*
     * Доп:
     * Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
     * Например, на выходе получается вот такой массив:
     * 01 02 03 04
     * 12 13 14 05
     * 11 16 15 06
     * 10 09 08 07
     */
    internal class Task62
    {
        internal static void FillSpiral()
        {
            int number = 1;
            var spiralArray = new string[4, 4];

            Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4." +
                "\n" + new string('-', 30));
            for (int i = 0; number < spiralArray.Length; i++)
            {
                int rowIndex = i;
                int columnIndex = i;
                for (; columnIndex < spiralArray.GetLength(1) - 1 - i; columnIndex++)
                    spiralArray[rowIndex, columnIndex] = String.Format("{0:00}",number++);
                for (; rowIndex < spiralArray.GetLength(1) - 1 - i; rowIndex++)
                    spiralArray[rowIndex, columnIndex] = String.Format("{0:00}",number++);
                for (; columnIndex > i; columnIndex--)
                    spiralArray[rowIndex, columnIndex] = String.Format("{0:00}",number++);
                for (; rowIndex > i; rowIndex--)
                    spiralArray[rowIndex, columnIndex] = String.Format("{0:00}",number++);
            }
            Console.WriteLine("Двумерный массив 4x4, заполненный спирально");
            for (int i = 0; i < spiralArray.GetLength(0); i++)
            {
                for (int j = 0; j < spiralArray.GetLength(1); j++)
                    Console.Write(spiralArray[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
