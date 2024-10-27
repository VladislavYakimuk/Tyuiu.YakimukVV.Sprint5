using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YakimukVV.Sprint5.Task2.V19.Lib
{
    public class DataService : ISprint5Task2V19
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            StringBuilder csvContent = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    csvContent.Append(matrix[i, j]);
                    if (j < matrix.GetLength(1) - 1)
                        csvContent.Append(";");
                }
                csvContent.AppendLine();
            }

            File.WriteAllText(filePath, csvContent.ToString());
            return filePath;
        }
    }
}
