using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KapisRM.Sprint3.Task2.V19.Lib
{
    public class DataService : ISprint3Task2V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double s = 0;
            int i = startValue;

            do
            {
                
                double term = Math.Cos(i) * 0.5;
                s += term;
                i++;
            }
            while (i <= stopValue);

            return Math.Round(s, 3);
        }
    }
}
