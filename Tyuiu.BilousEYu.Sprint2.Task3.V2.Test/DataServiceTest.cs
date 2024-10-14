using Tyuiu.BilousEYu.Sprint2.Task3.V2.Lib;
namespace Tyuiu.BilousEYu.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCondition1()
        {
            DataService ds = new DataService();
            double x = 4;
            Assert.AreEqual(-44.654, ds.Calculate(x));
        }
        [TestMethod]
        public void CheckCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            Assert.AreEqual(1.5, ds.Calculate(x));
        }
        [TestMethod]
        public void CheckCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            Assert.AreEqual(-11.707, ds.Calculate(x));
        }
        [TestMethod]
        public void CheckCondition4()
        {
            DataService ds = new DataService();
            double x = -10;
            Assert.AreEqual(-110, ds.Calculate(x));
        }
    }
}