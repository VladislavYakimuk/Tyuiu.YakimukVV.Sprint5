using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YakimukVV.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден: " + path);

            string content = File.ReadAllText(path);

            Regex regex = new Regex(@" {2,}");
            MatchCollection matches = regex.Matches(content);

            return matches.Count;
        }
    }
}
