using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SeledkovNP.Sprint2.Task0.V20.Lib
{
    public class DataService : ISprint2Task0V20
    {
        public bool[] GetCompareOperations(int x, int y)
        {
          
            bool[] result = new bool[6];

            result[0] = x == y + 800;
            result[1] = x != 1075;
            result[2] = y < x;
            result[3] = y > x;
            result[4] = y + 800 <= x;
            result[5] = y >= x;

            return result;
        }
    }
}
