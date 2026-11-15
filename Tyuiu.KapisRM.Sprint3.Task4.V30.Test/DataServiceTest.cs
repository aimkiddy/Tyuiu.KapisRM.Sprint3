using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint3.Task4.V30.Lib;

namespace Tyuiu.KapisRM.Sprint3.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);

            bool isValid = (res != 0);
            Assert.IsTrue(isValid);
        }
    }
}