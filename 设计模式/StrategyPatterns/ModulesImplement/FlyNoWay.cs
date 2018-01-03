using DesignMode.StrategyPatterns.IModuleServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode.StrategyPatterns.ModulesImplement
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.Write("不用飞行");
        }
    }
}
