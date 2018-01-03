using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>
    /// 调料
    /// </summary>
    public abstract class Condiment : Beverage
    {
        public abstract new string GetDescription();
    }
}
