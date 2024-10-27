using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YakimukVV.Sprint5.Task0.V23.Lib
{
    public class DataService : ISprint5Task0V23
    {
        public string SaveToFileTextData(int x)
        {
            double y = (1 + x * x * x) / (x * x);
            y = Math.Round(y, 2);

            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            File.WriteAllText(filePath, y.ToString());

            return filePath; 
        }
    }
}
