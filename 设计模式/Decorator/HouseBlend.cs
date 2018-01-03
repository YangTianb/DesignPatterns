using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend() {
            description = "HouseBlend Blend Coffee";
        }
        public override double Cost()
        {
            return 0.89;
        }
    }
}
