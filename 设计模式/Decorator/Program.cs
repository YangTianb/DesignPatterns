using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
          
            Console.WriteLine(beverage.GetDescription() + "$" + beverage.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocah(beverage2);
            beverage2 = new Mocah(beverage2);
            beverage2 = new Whip(beverage2);

            Console.WriteLine(beverage2.GetDescription()+"$"+beverage2.Cost());
            Console.ReadLine();
        }
    }
}
