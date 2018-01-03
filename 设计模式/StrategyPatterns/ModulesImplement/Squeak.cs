using DesignMode.StrategyPatterns.IModuleServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode.StrategyPatterns.ModulesImplement
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("吱吱的叫");
        }
    }
}
