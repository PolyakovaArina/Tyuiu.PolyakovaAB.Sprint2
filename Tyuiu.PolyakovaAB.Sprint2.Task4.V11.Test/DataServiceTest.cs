using Tyuiu.PolyakovaAB.Sprint2.Task4.V11.Lib;
namespace Tyuiu.PolyakovaAB.Sprint2.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            Assert.AreEqual(11, ds.Calculate(x, y));
        }
    }
}
