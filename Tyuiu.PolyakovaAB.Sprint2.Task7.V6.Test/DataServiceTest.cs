using Tyuiu.PolyakovaAB.Sprint2.Task7.V6.Lib;
namespace Tyuiu.PolyakovaAB.Sprint2.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x =1.5;
            double y = 0;
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}
