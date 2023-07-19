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
            int rowIndex = 0;
            int columnIndex = 0;
            int maxRow = 4;
            int maxColumn = 4;
            int minColumn = 0;
            int minRow = 0;
            var spiralArray = new int[maxRow, maxColumn];
            do
            {
                while (columnIndex < maxColumn)
                {
                    spiralArray[rowIndex, columnIndex] = number++;
                    columnIndex++;
                }
                rowIndex++;
                columnIndex--;
                while (rowIndex < maxRow)
                {
                    spiralArray[rowIndex, columnIndex] = number++;
                    rowIndex++;
                }
                rowIndex--;
                columnIndex--;
                while (columnIndex >= minColumn)
                {
                    spiralArray[rowIndex, columnIndex] = number++;
                    columnIndex--;
                }
                minRow++;
                rowIndex--;
                columnIndex++;
                while (rowIndex >= minRow)
                {
                    spiralArray[rowIndex, columnIndex] = number++;
                    rowIndex--;
                }
                minColumn++;
                maxColumn--;
                maxRow--;
                rowIndex++;
                columnIndex++;
            } while (number <= spiralArray.Length);
            for (int i = 0; i < spiralArray.GetLength(0); i++)
            {
                for (int j = 0; j < spiralArray.GetLength(1); j++)
                {
                    Console.Write(spiralArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
