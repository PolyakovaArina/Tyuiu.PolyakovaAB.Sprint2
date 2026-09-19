using Tyuiu.PolyakovaAB.Sprint2.Task0.V5.Lib;
namespace Tyuiu.PolyakovaAB.Sprint2.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Validxpression()
        {
            DataService ds = new DataService();
            int x = 100;
            int y = 200;
            bool[] re = new bool[6];
            re = ds.GetCompareOperations(x, y);
            bool[] res = new bool[6] {false, true, true, true, false, true};
            CollectionAssert.AreEqual(res,re);
        }
    }
}
