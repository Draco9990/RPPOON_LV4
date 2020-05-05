using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV4
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        public double[][] ConvertData(Dataset dataset)
        {
            IList<List<double>> matrixList = dataset.GetData();

            double[][] matrix = new double[matrixList.Count][];
            for(int i = 0; i < matrixList.Count;i++)
            {
                matrix[i] = new double[matrixList[i].Count];
            }
            
            for(int i = 0; i < matrixList.Count;i++)
            {
                for(int j = 0; j<matrixList[i].Count;j++)
                {
                    matrix[i][j] = matrixList[i][j];
                }
            }

            return matrix;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }

}
