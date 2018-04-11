using System;

namespace Test.Core
{
    public class Multiplo15: IObjectiveTest
    {
        public bool IsMultipleOf(int number)
        {
            return (number % 15) == 0;
        }

        public string GetPrintText()
        {
            return "fizzbuzz";
        }
    }
}