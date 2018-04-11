using System;

namespace Test.Core
{
    public class Multiplo1: IObjectiveTest
    {
        public bool IsMultipleOf(int number)
        {
            return true;
        }

        public string GetPrintText()
        {
            return "";
        }
    }
}