using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Tyuiu.YakimukVV.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (double.TryParse(line, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                    {
                        res += value;
                    }
                }
            }
            return res;
        }

        public double CalculateAverageInRange(string path, double minRange, double maxRange)
        {
            List<double> numbersInRange = new List<double>();

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (double.TryParse(line, NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                    {
                        if (number >= minRange && number <= maxRange)
                        {
                            numbersInRange.Add(number);
                        }
                    }
                }
            }

            if (numbersInRange.Count == 0)
            {
                return 0; 
            }

            double average = numbersInRange.Average();
            return Math.Round(average, 3); 
        }
    }
}
