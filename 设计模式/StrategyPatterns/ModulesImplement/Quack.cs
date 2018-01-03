using DesignMode.StrategyPatterns.IModuleServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode.StrategyPatterns.ModulesImplement
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("正常的叫");
        }
    }
}
