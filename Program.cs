using HomeworkSeminar17072023.Tasks;
using System;

namespace HomeworkSeminar17072023
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Задача №54");
                Task54.SortInDescending();
                WaitUser();
                Console.WriteLine("Задача №56");
                Task56.MinSumOfRow();
                WaitUser();
                Console.WriteLine("Задача №58");
                Task58.MultMatrices();
                WaitUser();
                Console.WriteLine("Задача №60");
                Task60.ThreeDimensionalArray();
                WaitUser();
                Console.WriteLine("Доп: Задача №62");
                Task62.FillSpiral();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("\nНажмите любую клавишу для выхода из программы...");
                Console.ReadKey(true);
            }
        }

        private static void WaitUser()
        {
            Console.WriteLine("\nНажмите любую клавишу для перехода к следующей задаче...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}