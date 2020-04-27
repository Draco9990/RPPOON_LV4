using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV4
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }

}
