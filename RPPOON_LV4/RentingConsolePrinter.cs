﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPPOON_LV4
{
    class RentingConsolePrinter
    {
        public void PrintTotalPrice(List<IRentable> items)
        {
            Console.WriteLine("Ukupna cijena: " + items.Sum(r => r.CalculatePrice()) + "kn");
        }
        public void DisplayItems(List<IRentable> items)
        {
            items.ForEach(r => Console.WriteLine(r.Description));
        }
    }
}
