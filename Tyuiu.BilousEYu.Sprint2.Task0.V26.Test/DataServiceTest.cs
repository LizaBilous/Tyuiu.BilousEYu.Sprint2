using Tyuiu.BilousEYu.Sprint2.Task0.V26.Lib;
namespace Tyuiu.BilousEYu.Sprint2.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1045;
            int y = 975;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, false, false, true, true, true };

            CollectionAssert.AreEqual(res, wait);

        }
    }
}