using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KapisRM.Sprint3.Task0.V13.Lib

{
    public class DataService : ISprint3Task0V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                // Формула: S = sum((a^k + 1/2) * cos(k))
                // где value — это 'a' (в вашем случае 0.5)
                double term = (Math.Pow(value, k) + 0.5) * Math.Cos(k);
                s += term;
            }

            return Math.Round(s, 3);
        }
    }
}
