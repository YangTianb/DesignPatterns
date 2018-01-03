using StrategyPatterns.IModuleServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatterns
{
    /// <summary>
    /// 抽象类
    /// </summary>
    public abstract class BaseInfo
    {
        public IPushBehavior pushBehavior;

        public void PerormPush() {
            pushBehavior.Push();
        }

    }
}
