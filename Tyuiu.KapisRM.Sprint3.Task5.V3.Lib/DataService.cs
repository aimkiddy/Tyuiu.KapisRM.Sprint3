using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KapisRM.Sprint3.Task5.V3.Lib
{
    public class DataService : ISprint3Task5V3
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double s1 = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                double s0 = 0;
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    s0 += (Math.Sin(k) + x) / x;
                }
                s1 += s0;
            }
            return Math.Round(s1, 3);
        }
    }
}
