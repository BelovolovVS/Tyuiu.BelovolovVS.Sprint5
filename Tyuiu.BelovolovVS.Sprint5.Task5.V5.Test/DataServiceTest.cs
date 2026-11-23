using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BelovolovVS.Sprint5.Task5.V5.Lib;

namespace Tyuiu.BelovolovVS.Sprint5.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V5.txt");
            File.WriteAllText(path, "1.5\n2\n-3\n4.7\n5");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}