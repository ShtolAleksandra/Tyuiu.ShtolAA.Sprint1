using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint1.Task6.V16.Lib;

namespace Tyuiu.ShtolAA.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Что ты сделал?!";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
