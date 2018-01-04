using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Whip : Condiment
    {
        Beverage beverage;
        public Whip(Beverage beverage) {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return 0.8 + beverage.Cost();
        }
 

        public override string GetDescription()
        {
            return beverage.GetDescription() + ",Whip";
        }
    }
}
