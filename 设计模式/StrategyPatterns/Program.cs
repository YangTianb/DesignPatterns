using System;

namespace DesignMode.StrategyPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck d = new MallardDuck();
            d.PerormFly();
            d.PerormQuack();
            Console.ReadLine();

            Console.ReadLine();


        }
    }
}
