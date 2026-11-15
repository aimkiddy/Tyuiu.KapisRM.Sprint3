using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint3.Task6.V23.Lib;

namespace Tyuiu.KapisRM.Sprint3.Task6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 18;
            int stopValue = 28;
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.IsTrue(res > 0);
        }
    }
}