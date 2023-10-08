using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint1.Task7.V14.Lib;

namespace Tyuiu.ShtolAA.Sprint1.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 8;
            double wait = 0.823;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
