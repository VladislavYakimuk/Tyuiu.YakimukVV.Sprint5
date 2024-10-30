using System;
using System.IO;
using Tyuiu.YakimukVV.Sprint5.Task7.V24.Lib;

namespace Tyuiu.YakimukVV.Sprint5.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Якимук В. В. | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Якимук Владислав Владимирович | ИБКСб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\DataSprint5\InPutDataFileTask7V24.txt в котором есть набор  *");
            Console.WriteLine("* символьных данных. Заменить все русские слова на слово <слово>.         *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V24.txt        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V24.txt";
            string res = File.ReadAllText(path);
            Console.WriteLine(res);
            Console.WriteLine("Файл находится тут: " + path);

            Console.WriteLine("****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                   *");
            Console.WriteLine("****************************************************************");

            string outputFilePath = ds.LoadDataAndSave(path);
            Console.WriteLine($"Файл сохранен: {outputFilePath}");
            Console.ReadKey();
        }
    }
}
