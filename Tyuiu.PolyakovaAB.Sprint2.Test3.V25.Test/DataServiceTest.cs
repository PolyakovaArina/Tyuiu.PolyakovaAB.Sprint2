using Tyuiu.PolyakovaAB.Sprint2.Test3.V25.Lib;
namespace Tyuiu.PolyakovaAB.Sprint2.Test3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService  ds = new DataService();
            double x = 1;
            Assert.AreEqual(2,ds.Calculate(x));
        }
    }
}
