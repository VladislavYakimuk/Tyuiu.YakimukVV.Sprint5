using Tyuiu.YakimukVV.Sprint5.Task6.V17.Lib;
namespace Tyuiu.YakimukVV.Sprint5.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask6V17.txt");
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Кол-во пробелов: " + res);

            Console.ReadKey();

        }
    }
}
