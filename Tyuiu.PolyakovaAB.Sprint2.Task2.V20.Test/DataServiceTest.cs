using Tyuiu.PolyakovaAB.Sprint2.Task2.V20.Lib;
namespace Tyuiu.PolyakovaAB.Sprint2.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 13;
            int y = 7;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));

        }
    }
}
