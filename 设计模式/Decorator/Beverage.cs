using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>
    /// 饮料
    /// </summary>
    public abstract class Beverage
    {
       public string description = "Unknown Beverage";

        public virtual string GetDescription() {
            return description;
        }

        public abstract double Cost();
    }
}
