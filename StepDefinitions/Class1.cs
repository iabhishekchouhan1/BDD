using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.StepDefinitions
{
    [Binding]
    internal class Class1
    {
        [Given(@"Open firefox")]
        public void GivenOpenFirefox()
        {
            Console.WriteLine("Open Firefox***************");
        }

        [Given(@"Open chrome")]
        public void GivenOpenChrome()
        {
            Console.WriteLine("Open Chrome***************");
        }

        [Given(@"B")]
        public void GivenB()
        {
            Console.WriteLine("Given B*************");
        }

        [When(@"C")]
        public void WhenC()
        {
            Console.WriteLine("When C*********");
        }

        [Then(@"D")]
        public void ThenD()
        {
            Console.WriteLine("Then B***********");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Before Scenario********************");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("After Scenario********************");
        }

    }
}
