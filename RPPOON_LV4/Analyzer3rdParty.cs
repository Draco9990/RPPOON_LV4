using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPPOON_LV4
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int rowCount = data.Length;
            int columnCount = data[0].Length;
            double[] results = new double[columnCount];
            for(int i = 0; i < columnCount; i++)
            {
                double[] column = new double[rowCount];
                for (int j = 0; j<rowCount;j++)
                {
                    column[j] = data[j][i];
                }
                results[i] = column.Average();
            }
            return results;
        }
    }

}
