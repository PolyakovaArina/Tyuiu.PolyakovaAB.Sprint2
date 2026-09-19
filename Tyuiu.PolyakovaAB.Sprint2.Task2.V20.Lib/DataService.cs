using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PolyakovaAB.Sprint2.Task2.V20.Lib
{
    public class DataService : ISprint2Task2V20
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((3 <= x) && (x <= 5) && (3 <= y) && (y <= 5)) || ((6 <= x)&&(x <= 9) && (5 <= y)&&(y <= 8)) || ((9 <= x)&&(x <= 12) && (8 <= y)&&(y <= 12)) || ((x == 3) && (y == 6)) || ((x == 9) && (3 <= y)&&(y <= 4)) || ((3 <= x)&&(x <= 6) && (y == 11)) || ((x == 6) && (9 <= y)&&(y <= 10)) || ((10 <= x)&&(x <= 10) && (y == 13)) || ((x == 13) && (6 <= y)&&(y <= 8)))
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
