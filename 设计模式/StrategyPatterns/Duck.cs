using DesignMode.StrategyPatterns.IModuleServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode.StrategyPatterns
{
    public abstract class Duck
    {
        public  IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;
        public void PerormFly() {
            flyBehavior.Fly();
        }

        public void PerormQuack() {
            quackBehavior.Quack();
        }
        public void Swim() { }

        public abstract void Display();       

    }
}
