﻿using Tyuiu.YakimukVV.Sprint5.Task5.V13.Lib;
using System;
using System.IO;

namespace Tyuiu.YakimukVV.Sprint5.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask5V13.txt");
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.LoadFromDataFile(path);
            Console.WriteLine("Среднее значение чисел в диапазоне [-1.5, 1.5]: " + result.ToString("F3"));
            Console.ReadKey();
        }
    }
}