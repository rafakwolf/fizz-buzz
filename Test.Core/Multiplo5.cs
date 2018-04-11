using System;

namespace Test.Core
{
    public class Multiplo5: IObjectiveTest
    {
        public bool IsMultipleOf(int number)
        {
            return (number % 5) == 0;
        }

        public string GetPrintText()
        {
            return "buzz";
        }
    }
}