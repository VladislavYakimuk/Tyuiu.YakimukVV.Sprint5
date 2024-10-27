using System;
using Tyuiu.YakimukVV.Sprint5.Task2.V19.Lib;

namespace Tyuiu.YakimukVV.Sprint5.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];

            Console.WriteLine("Введите элементы 3x3 матрицы:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());

                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            DataService dataService = new DataService();
            string filePath = dataService.SaveToFileTextData(matrix);
            Console.WriteLine("Файл: " + filePath);
            Console.WriteLine("Создан!");

            Console.WriteLine("Измененный массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
