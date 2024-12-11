using Tyuiu.BorkovNA.Sprint6.Task0.V22.Lib;

namespace Tyuiu.BorkovNA.Sprint6.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new();
            Assert.AreEqual(2.22, ds.Calculate(1));
        }
    }
}