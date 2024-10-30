using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.YakimukVV.Sprint5.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\jetjo\AppData\Local\Temp\DataSprint5\InPutDataFileTask7V24.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
