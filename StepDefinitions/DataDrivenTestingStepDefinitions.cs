using OpenQA.Selenium;
using SpecflowProject.Pages;
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
            //IWebElement SearchBox = driver.FindElement(By.XPath("//input[@id='search']"));
            //SearchBox.SendKeys(SearchChannel);
            //SearchBox.Submit();
            //Thread.Sleep(5000);
            HomePage HP = new HomePage(driver);
            HP.SearchYoutube(SearchChannel);
        }

        [When(@"Search for ([^']*)")]
        public void WhenSearchForBecauseItsInteresting(string SearchChannel)
        {
            HomePage HP = new HomePage(driver);
            HP.SearchYoutube(SearchChannel);
        }

       
        [Then(@"Verify the Channel should be displayed ([^']*)")]
        public void ThenVerifyTheChannelShouldBeDisplayedBecauseItsInteresting(string ChannelFound)
        {
            Assert.True(driver.Title.Contains(ChannelFound));
        }


    }

}

