using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.YakimukVV.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    res += Convert.ToDouble(line);
                }
            }
            return res;
        }

        public double CalculateAverageInRange(string path, double minValue, double maxValue)
        {
            double sum = 0;
            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double value = Convert.ToDouble(line);
                    if (value >= minValue && value <= maxValue)
                    {
                        sum += value;
                        count++;
                    }
                }
            }

            return count > 0 ? sum / count : 0; 
        }
    }
}
