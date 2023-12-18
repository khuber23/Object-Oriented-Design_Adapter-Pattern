using AdapterPattern.Adapter;
using System;
using TurkeyService;

namespace AdapterPattern
{
    internal class Program
    {
        public static void TestDuck(Duck duck)
        {
            duck.Fly();
            duck.Quack();
        }

        private static void Main(string[] args)
        {
            WildTurkey wildturkey = new WildTurkey();
            Console.WriteLine("Testing the turkey...");
            TurkeyAdapter turkeyDuck = new TurkeyAdapter(wildturkey);
            TestDuck(turkeyDuck);
            Console.WriteLine();

            Console.WriteLine("Testing the duck...");
            Duck duck = new MallardDuck();
            TestDuck(duck);
            Console.Read();
        }
    }
}