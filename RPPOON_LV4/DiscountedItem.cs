using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV4
{
    class DiscountedItem:RentableDecorator
    {
        private double DiscountPerc = 20;
        public DiscountedItem(IRentable rentable) : base(rentable) { }
        public override double CalculatePrice()
        {
            return base.CalculatePrice()*(1-(DiscountPerc/100));
        }

        public void SetDiscountPerc(float discPerc)
        {
            DiscountPerc = discPerc;
        }

        public override String Description
        {
            get
            {
                return base.Description + " - now at " + DiscountPerc + "% off!";
            }
        }
    }
}
