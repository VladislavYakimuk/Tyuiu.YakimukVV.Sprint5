using Tyuiu.YakimukVV.Sprint5.Task1.V20.Lib;
namespace Tyuiu.YakimukVV.Sprint5.Task1.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            string filePath = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + filePath);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
