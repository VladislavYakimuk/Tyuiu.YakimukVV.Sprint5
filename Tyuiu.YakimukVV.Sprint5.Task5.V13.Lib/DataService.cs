using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YakimukVV.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            double aver = 0;
            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var numberStr in numbers)
                    {
                        if (double.TryParse(numberStr, out double number))
                        {
                            if (number >= -1.5 && number <= 1.5)
                            {
                                aver += number;
                                count++;
                            }
                        }
                    }
                }
            }

            if (count == 0)
            {
                throw new InvalidOperationException("Не найдено валидных чисел в заданном диапазоне.");
            }

            double res = aver / count;
            return res;
        }
    }
}
