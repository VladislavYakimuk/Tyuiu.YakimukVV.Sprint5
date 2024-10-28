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
            List<double> validNumbers = new List<double>();

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {

                    if (double.TryParse(line, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                    {

                        if (value >= -1.5 && value <= 1.5)
                        {
                            validNumbers.Add(value);
                        }
                    }
                }
            }

            if (validNumbers.Count > 0)
            {
                res = validNumbers.Average();
            }

            return Math.Round(res, 3);
        }
    }
}
