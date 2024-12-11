using Tyuiu.BorkovNA.Sprint6.Task1.V16.Lib;

namespace Tyuiu.BorkovNA.Sprint6.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] res = { 59.49, 38.47, -2.81, -19.67, -8.42, 0.57, -6.3, -20.14, -3.51, 38.13, 59.6 };
            DataService ds = new();
            CollectionAssert.AreEqual(res, ds.GetMassFunction(-5, 5));
        }
    }
}