using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.Hooks
{
    [Binding]
    internal class C1
    {
        [BeforeScenario] //before scenario hook
        public static void BeforeSc()
        {
            Console.WriteLine("Hook before scenario*************");
        }



        [AfterScenario] //After scenario hook
        public static void AfterSc()
        {
            Console.WriteLine("Hook After scenario*************");
        }
        [BeforeFeature] //before scenario hook
        public static void BeforeFea()
        {
            Console.WriteLine("Hook before featur*************");
        }
        [AfterFeature] //before scenario hook
        public static void AfterFea()
        {
            Console.WriteLine("Hook after feature*************");
        }


        [BeforeScenario("categoryA")]
        public void BeforeCategoryA()
        {
            Console.WriteLine("****************This will execute before category a*************");
        }
    }
}
