using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV4
{
    interface IAnalytics
    {
        double[] CalculateAveragePerColumn(Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);
    }
}
