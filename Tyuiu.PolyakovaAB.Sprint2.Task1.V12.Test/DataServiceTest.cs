using Tyuiu.PolyakovaAB.Sprint2.Task1.V12.Lib;
namespace Tyuiu.PolyakovaAB.Sprint2.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 152;
            int b = 116;
            int c = 887;
            int d = 556;
            bool[] res = new bool[6] { true, true, true, false, true, false };
            CollectionAssert.AreEqual(res, ds.GetLogicOperations(a, b, c, d));

        }
    }
}
