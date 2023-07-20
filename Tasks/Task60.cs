using System;
using System.Linq;

namespace HomeworkSeminar17072023.Tasks
{
    /*
     * Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
     * Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
     * Массив размером 2 x 2 x 2
     * 66(0,0,0) 25(0,1,0)
     * 34(1,0,0) 41(1,1,0)
     * 27(0,0,1) 90(0,1,1)
     * 26(1,0,1) 55(1,1,1)
     */
    internal class Task60
    {
        internal static void ThreeDimensionalArray()
        {
            var rnd = new Random();
            var array = new int[2, 2, 2];
            var allNumbers = new int[array.Length];

            Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. " +
                "Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента." +
                "\n" + new string('-', 30));
            Console.WriteLine("Трехмерный массив из неповторяющихся двузначных чисел");
            for (int i = 0, index = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); )
                    {
                        int number = rnd.Next(10, 100);
                        if (!allNumbers.Any(x => x == number))
                        {
                            array[i, j, k] = number;
                            allNumbers[index++] = number;
                            Console.Write("{0}({1},{2},{3})\t", number, i, j, k);
                            k++;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
