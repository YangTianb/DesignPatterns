using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Mocah : Condiment
    {
        Beverage beverage;

        public Mocah(Beverage beverage) {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return  0.2 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ",Mocha";
        }
    }
}
