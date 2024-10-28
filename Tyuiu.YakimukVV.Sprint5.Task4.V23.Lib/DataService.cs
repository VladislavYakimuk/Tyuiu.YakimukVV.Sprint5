using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.YakimukVV.Sprint5.Task4.V23.Lib
{
    public class DataService : ISprint5Task4V23
    {
        public double LoadFromDataFile(string path)
        {
            string x = File.ReadAllText(path);
            double y = Math.Pow(Convert.ToDouble(x), -3) + 2 + Math.Cos(Convert.ToDouble(x));

            return Math.Round(y, 3);
        }
    }
}
