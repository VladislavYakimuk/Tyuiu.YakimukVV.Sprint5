using Tyuiu.YakimukVV.Sprint5.Task5.V13.Lib;
namespace Tyuiu.YakimukVV.Sprint5.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask5V13.txt");
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            double average = ds.CalculateAverageInRange(path, -1.5, 1.5);
            Console.WriteLine("Среднее значение чисел в диапазоне [-1.5, 1.5]: " + Math.Round(average, 3));

            Console.ReadKey();
        }
    }
}
