using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Tyuiu.YakimukVV.Sprint5.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFileCreation()
        {
            string filePath = @"C:\Users\jetjo\AppData\Local\Temp\OutPutFileTask2.csv";

            Assert.IsTrue(File.Exists(filePath), "Файл не был создан по ожидаемому пути.");
        }
    }
}
