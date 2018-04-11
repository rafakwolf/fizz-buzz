using System;
using Test.Core;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IObjectiveTest multiplo15 = new Multiplo15();
            IObjectiveTest multiplo3 = new Multiplo3();
            IObjectiveTest multiplo5 = new Multiplo5();
            IObjectiveTest multiplo1 = new Multiplo1();

            var tester = new ObjectiveTest();

            tester.AddTester(multiplo15);
            tester.AddTester(multiplo5);
            tester.AddTester(multiplo3);
            tester.AddTester(multiplo1);

            tester.RunTests(100);

            Console.ReadLine();
        }
    }
}
