using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YakimukVV.Sprint5.Task7.V24.Lib
{
    public class DataService : ISprint5Task7V24
    {
        public string LoadDataAndSave(string path)
        {
            string data = File.ReadAllText(path);
            string modifiedData = Regex.Replace(data, @"\b[а-яА-ЯёЁ]+\b", "слово");

            string tempDirectory = Path.GetTempPath();  
            string outputPath = Path.Combine(tempDirectory, "OutPutDataFileTask7V24.txt");

            File.WriteAllText(outputPath, modifiedData);

            return outputPath;  
        }
    }
}
