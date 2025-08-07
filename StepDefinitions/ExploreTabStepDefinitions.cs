using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using SpecflowProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SpecflowProject.StepDefinitions
{
    [Binding]
    public sealed class ExploreTabStepDefinitions
    {
        private IWebDriver driver;
        private WaitHelper wait;
        public ExploreTabStepDefinitions(IWebDriver driver, WaitHelper wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

       

    }
}
