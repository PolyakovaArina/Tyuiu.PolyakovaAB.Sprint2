using Tyuiu.PolyakovaAB.Sprint2.Task6.V3;
using Tyuiu.PolyakovaAB.Sprint2.Task6.V3.Lib;
namespace Tyuiu.PolyakovaAB.Sprint2.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual("суббота", ds.FindDayName(6));
        }
    }
}
