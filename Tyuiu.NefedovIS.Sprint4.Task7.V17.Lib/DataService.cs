﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NefedovIS.Sprint4.Task7.V17.Lib
{
    public class DataService : ISprint4Task7V17
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value[i * 3 + j].ToString());
                }
            }

            int cntr = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        cntr++;
                    }
                }
            }
            return cntr;
        }
    }
}
