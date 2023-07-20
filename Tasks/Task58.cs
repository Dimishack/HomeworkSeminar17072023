using System;

namespace HomeworkSeminar17072023.Tasks
{
    /*
     * Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
     * Например, даны 2 матрицы:
     * 2 4 | 3 4
     * 3 2 | 3 3
     * Результирующая матрица будет:
     * 18 20
     * 15 18
     */
    internal class Task58
    {
        internal static void MultMatrices()
        {
            int[,] Matrix(int row, int column, string quantityMatrix)
            {
                var random = new Random();
                var matrix = new int[row, column];

                Console.WriteLine("{0} матрица {1}x{2} (из цифр)",quantityMatrix, row, column);
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        matrix[i, j] = random.Next(1, 10);
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                return matrix;
            }
            var rnd = new Random();
            int quantityRowsAndColumns = rnd.Next(2, 6);


            Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц." +
                "\n" + new string('-', 30));
            var firstMatrix = Matrix(rnd.Next(2, 6), quantityRowsAndColumns, "Первая");
            var secondMatrix = Matrix(quantityRowsAndColumns, rnd.Next(2, 6), "Вторая");
            var multMatrices = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
            Console.WriteLine("Действия");
            for (int i = 0; i < secondMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(0); j++)
                {
                    var result = 0;

                    Console.Write("C({0},{1}) = ", j+1, i+1);
                    for (int k = 0; k < firstMatrix.GetLength(1); k++)
                    {
                        result += firstMatrix[j, k] * secondMatrix[k, i];
                        Console.Write("{0} * {1}", firstMatrix[j, k], secondMatrix[k, i]);
                        if (k < firstMatrix.GetLength(1) - 1) Console.Write(" + ");
                    }
                    multMatrices[j, i] = result;
                    Console.WriteLine(" = " + result);
                }
            }
            Console.WriteLine("Результат произведения матриц");
            for (int i = 0; i < multMatrices.GetLength(0); i++)
            {
                for (int j = 0; j < multMatrices.GetLength(1); j++)
                    Console.Write(multMatrices[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
