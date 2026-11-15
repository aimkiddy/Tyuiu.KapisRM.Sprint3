using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint3.Task5.V3.Lib;

namespace Tyuiu.KapisRM.Sprint3.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1, stopValue1 = 3;
            int startValue2 = 1, stopValue2 = 11;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            bool isValid = (res != 0);
            Assert.IsTrue(isValid);
        }
    }
}
