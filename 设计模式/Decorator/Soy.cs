using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Soy : Condiment
    {
        Beverage beverage;
        public Soy(Beverage beverage) {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return 0.4 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + ",Soy";
        }
    }
}
