using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var spiralArray = new int[4, 4];
            for (int i = 0; number <= spiralArray.Length && i < spiralArray.Length / 2; i++)
            {
                int rowIndex = 0 + i;
                int columnIndex = 0 + i;
                for (; columnIndex < spiralArray.GetLength(1) - 1 - i; columnIndex++)
                    spiralArray[rowIndex, columnIndex] = number++;
                for (; rowIndex < spiralArray.GetLength(1) - 1 - i; rowIndex++)
                    spiralArray[rowIndex, columnIndex] = number++;
                for (; columnIndex > i; columnIndex--)
                    spiralArray[rowIndex, columnIndex] = number++;
                for (; rowIndex > i; rowIndex--)
                    spiralArray[rowIndex, columnIndex] = number++;
            }
            for (int i = 0; i < spiralArray.GetLength(0); i++)
            {
                for (int j = 0; j < spiralArray.GetLength(1); j++)
                    Console.Write(spiralArray[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
