namespace Tyuiu.BorkovNA.Sprint6.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[5, 5] { { 1, 1, 1, 1, 21 },
                                      { 1, 1, 1, 1, 1 },
                                      { 1, 1, 1, 1, 50 },
                                      { 1, 1, 1, 1, 2 },
                                      { 1, 1, 1, 1, -21 }};
            int[,] res = ds.Calculate(mtrx);
            int[] finalres = new int[] { res[0, 4], res[1, 4], res[2, 4], res[3, 4], res[4, 4] };
            int[] wait = new int[] { -21, 1, 2, 21, 50 };
            CollectionAssert.AreEqual(wait, finalres);
        }
    }
}