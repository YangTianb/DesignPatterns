using DesignMode.StrategyPatterns.ModulesImplement;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode.StrategyPatterns
{
    public class MallardDuck : Duck
    {

        public MallardDuck() {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.Write("i'm a real mallard duck");
        }
    }
}
