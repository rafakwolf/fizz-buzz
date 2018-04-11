using System;

namespace Test.Core
{
    public class Multiplo3: IObjectiveTest
    {
        public bool IsMultipleOf(int number)
        {
            return (number % 3) == 0;
        }

        public string GetPrintText()
        {
            return "fizz";
        }
    }
}