﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BorkovNA.Sprint6.Task2.V22.Lib
{
    public class DataService : ISprint6Task2V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            int i = 0;
            while (i < res.Length)
            {
                if (startValue + i == -1.2)
                {
                    res[i] = 0;
                    i++;
                    continue;
                }
                res[i] = F(startValue + i);
                i++;
            }
            return res;
        }
        public double F(int x)
        {
            return Math.Round(Math.Sin(x) / (x - 1.2) + Math.Cos(x) * (7 * x) - 2, 2);
        }
    }
}
