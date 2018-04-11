using System;
using System.Collections.Generic;

namespace Test.Core
{
    public class ObjectiveTest
    {
        private readonly IList<IObjectiveTest> _testers;

        public ObjectiveTest()
        {
            _testers = new List<IObjectiveTest>();
        }

        public void AddTester(IObjectiveTest testObj)
        {
            _testers.Add(testObj);
        }

        public void RunTests(int maxNumber)
        {
            for (int i = 1; i < maxNumber; i++)
            {
                foreach (var tester in _testers)
                {
                    if (tester.IsMultipleOf(i))
                    {
                        Console.WriteLine(
                            string.IsNullOrEmpty(tester.GetPrintText()) ? i.ToString() : tester.GetPrintText());
                        break;
                    }
                }
            }
        }
    }
}
