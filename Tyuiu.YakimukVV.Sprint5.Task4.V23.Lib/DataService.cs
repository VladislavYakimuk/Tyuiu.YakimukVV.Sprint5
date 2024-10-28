using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YakimukVV.Sprint5.Task4.V23.Lib
{
    public class DataService : ISprint5Task4V23
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"File not found: {path}");

            try
            {
                string fileContent = File.ReadAllText(path).Trim();

                if (!double.TryParse(fileContent, NumberStyles.Float, CultureInfo.InvariantCulture, out double x))
                    throw new FormatException("Invalid data format in file. Ensure the number is in correct format, e.g., '3.47'");

                double y = Math.Pow(x, -3) + 2 + Math.Cos(x);

                return Math.Round(y, 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing file data: {ex.Message}");
                throw;
            }
        }
    }
}
