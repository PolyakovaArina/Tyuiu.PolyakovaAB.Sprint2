using Tyuiu.PolyakovaAB.Sprint2.Task5.V5.Lib;
namespace Tyuiu.PolyakovaAB.Sprint2.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressioin()
        {
            DataService ds = new DataService();
            int a = 6;
            Assert.AreEqual("шестёрка", ds.FindCardValue(a));
        }
    }
}
