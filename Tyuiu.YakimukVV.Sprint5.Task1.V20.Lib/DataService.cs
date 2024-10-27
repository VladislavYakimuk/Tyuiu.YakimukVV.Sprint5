using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YakimukVV.Sprint5.Task1.V20.Lib
{
    public class DataService : ISprint5Task1V20
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double fx;
                    try
                    {
                        fx = CalculateFunction(x);
                    }
                    catch (DivideByZeroException)
                    {
                        fx = 0;
                    }
                    fx = Math.Round(fx, 2);
                    writer.WriteLine(fx.ToString().Replace(',', '.'));
                }
            }
            return filePath;
        }

        private double CalculateFunction(int x)
        {
            double denominator = Math.Sin(x) + 3;
            if (Math.Abs(denominator) < 1e-10) 
            {
                throw new DivideByZeroException();
            }
            return (5 * x + 2.5) / denominator + 2 * x + Math.Cos(x);
        }
    }
}
