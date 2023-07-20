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
                ConsoleKey key;
                Console.WriteLine("Добро пожаловать в программу с выполненными задачами №54, 56, 58, 60 и 62");
                do
                {
                    Console.WriteLine("Выберите номер из списка с задачами, к которому Вы хотите перейти " +
                        "\n(для выхода из программы нажмите <Enter>)");
                    Console.WriteLine("1) Задача №54 \n2) Задача №56 \n3) Задача №58 \n4) Задача №60 \n5) Задача №62");
                    key = Console.ReadKey(false).Key;
                    Console.WriteLine();
                    switch (key)
                    {
                        case ConsoleKey.Enter:
                            break;
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.D1:
                            Task54.SortInDescending();
                            WaitUser();
                            break;
                        case ConsoleKey.NumPad2:
                        case ConsoleKey.D2:
                            Task56.MinSumOfRow();
                            WaitUser();
                            break;
                        case ConsoleKey.NumPad3:
                        case ConsoleKey.D3:
                            Task58.MultMatrices();
                            WaitUser();
                            break;
                        case ConsoleKey.NumPad4:
                        case ConsoleKey.D4:
                            Task60.ThreeDimensionalArray();
                            WaitUser();
                            break;
                        case ConsoleKey.NumPad5:
                        case ConsoleKey.D5:
                            Task62.FillSpiral();
                            WaitUser();
                            break;
                        default:
                            Console.WriteLine("Ошибка: Данного номера с задачей нет! Выберите другой.");
                            break;
                    }
                } while (key != ConsoleKey.Enter);
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