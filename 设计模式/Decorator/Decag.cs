using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Decag : Beverage
    {
        public Decag() {
            description = "Decag";
        }
        public override double Cost()
        {
            return 0.15;
        }
    }
}
