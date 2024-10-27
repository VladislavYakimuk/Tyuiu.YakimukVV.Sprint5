using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Tyuiu.YakimukVV.Sprint5.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFileCreation()
        {
            string filePath = @"C:\Users\jetjo\AppData\Local\Temp\OutPutFileTask1.txt";

            Assert.IsTrue(File.Exists(filePath), "Файл не был создан по ожидаемому пути.");
        }
    }
}
