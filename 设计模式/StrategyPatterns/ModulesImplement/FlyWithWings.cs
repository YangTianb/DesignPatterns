using DesignMode.StrategyPatterns.IModuleServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode.StrategyPatterns.ModulesImplement
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("正常飞行了");
        }
    }
}
