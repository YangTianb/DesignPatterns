using DesignMode.StrategyPatterns.IModuleServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode.StrategyPatterns.ModulesImplement
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("不叫");
        }
    }
}
