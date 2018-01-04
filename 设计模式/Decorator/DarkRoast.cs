using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast() {
            description = "DarkRoast";
        }
        public override double Cost()
        {
            return 0.4;
        }
        public override string GetDescription()
        {
            return "Dark Roast Coffee";
        }
    }
}
