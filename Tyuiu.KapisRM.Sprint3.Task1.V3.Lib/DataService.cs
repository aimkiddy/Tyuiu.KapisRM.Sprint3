using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KapisRM.Sprint3.Task1.V3.Lib
{
    public class DataService : ISprint3Task1V3
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;
            int k = startValue;

            while (k <= stopValue)
            {
                
                double term = k / Math.Pow(Math.Cos(5) + 1, 2);
                p *= term;
                k++;
            }

            return Math.Round(p, 3);
        }
    }
}
