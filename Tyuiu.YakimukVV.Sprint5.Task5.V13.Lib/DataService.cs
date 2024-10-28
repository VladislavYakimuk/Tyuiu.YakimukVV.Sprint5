using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.YakimukVV.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        foreach (string part in parts)
                        {
                            if (double.TryParse(part, out double number))
                            {
                                res += number;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }

            return res;
        }

        public double CalculateAverageInRange(string path, double minValue, double maxValue)
        {
            double sum = 0;
            int count = 0;

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        foreach (string part in parts)
                        {
                            if (double.TryParse(part, out double number))
                            {
                                if (number >= minValue && number <= maxValue)
                                {
                                    sum += number;
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при обработке файла: {ex.Message}");
            }

            return count > 0 ? sum / count : 0;
        }
    }
}
