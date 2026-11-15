using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KapisRM.Sprint3.Task7.V21.Lib
{
    public class DataService : ISprint3Task7V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2 * x - 1;
                double y;

                if (denominator == 0)
                {
                    y = 0; 
                }
                else
                {
                    y = (2 * Math.Cos(x) + 2) / denominator + Math.Cos(x) - 5 * x + 3;
                }

                valueArray[index] = Math.Round(y, 2); 
                index++;
            }

            return valueArray;
        }
    }
}
