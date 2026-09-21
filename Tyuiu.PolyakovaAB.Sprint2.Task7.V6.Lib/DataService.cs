using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PolyakovaAB.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            DataService ds = new DataService();
            bool res = false;
            if ((x * x + y * y <= 4) && (x * x + y * y >= 1))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
