using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace SpecflowProject.StepDefinitions
{
    [Binding]
    public sealed class DataDrivenTestingStepDefinitions
    {
        private IWebDriver driver;
        public DataDrivenTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [When(@"Search for '([^']*)'")]
        public void WhenSearchFor(string SearchChannel)
        {
            IWebElement SearchBox = driver.FindElement(By.XPath("//input[@id='search']"));
            SearchBox.SendKeys(SearchChannel);
            SearchBox.Submit();
            Thread.Sleep(5000);
        }

        [When(@"Search for ([^']*)")]
        public void WhenSearchForBecauseItsInteresting(string SearchChannel)
        {
            IWebElement SearchBox = driver.FindElement(By.XPath("//input[@id='search']"));
            SearchBox.SendKeys(SearchChannel);
            SearchBox.Submit();
            Thread.Sleep(5000);
        }

        //For multiple test data
        [Then(@"Verify the Channel should be displayed")]
        public void ThenVerifyTheChannelShouldBeDisplayed(Table table)
        {
            var SearchCriteria = table.CreateSet<SearchChannelTestData>();
            //It should iterate through all the test data 
            foreach(var keyword in SearchCriteria)
            {
                IWebElement VerifySearch = driver.FindElement(By.XPath("//*[contains(text(),ChannelFound)]"));
                if (VerifySearch.Displayed)
                    Console.WriteLine(VerifySearch.Text);
                else
                    Console.WriteLine("Channel Not Found");
            }
        }

        //Use get and set To verify multiple test data
        public class SearchChannelTestData
        {
            public string SearchChannel { get; set; }
            public string ChannelFound { get; set; }
        }

    }

}

