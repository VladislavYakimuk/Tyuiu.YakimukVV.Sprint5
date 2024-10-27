using Tyuiu.YakimukVV.Sprint5.Task0.V23.Lib;
namespace Tyuiu.YakimukVV.Sprint5.Task0.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
