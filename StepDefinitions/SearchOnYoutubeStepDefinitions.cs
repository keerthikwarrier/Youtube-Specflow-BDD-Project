using OpenQA.Selenium;
using SpecflowProject.Pages;
using SpecflowProject.Utilities;
using System;
using System.Data.SqlTypes;
using TechTalk.SpecFlow;

namespace SpecflowProject.StepDefinitions
{
    [Binding]
    public sealed class SearchOnYoutubeStepDefinitions 
    {
        private IWebDriver driver;
        private WaitHelper wait;
        public SearchOnYoutubeStepDefinitions(IWebDriver driver, WaitHelper wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        [When(@"Search Because Its Interesting")]
        public void WhenSearchBecauseItsInteresting()
        {
            HomePage HP = new HomePage(driver,wait);
            HP.SearchYoutube("Because Its Interesting");
        }

        [Then(@"Because Its Interesting channel should be displayed")]
        public void ThenBecauseItsInterestingChannelShouldBeDisplayed()
        {
           Assert.True(driver.Title.Contains("Because Its Interesting"));
        }

    }
}
