using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KapisRM.Sprint3.Task0.V13.Lib;

namespace Tyuiu.KapisRM.Sprint3.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double a = 0.5;
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetSumSeries(a, startValue, stopValue);

            double wait = 0.298;


            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
