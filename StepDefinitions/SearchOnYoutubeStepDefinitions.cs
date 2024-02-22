using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V119.FedCm;
using SpecflowProject.Pages;
using System;
using System.Data.SqlTypes;
using TechTalk.SpecFlow;

namespace SpecflowProject.StepDefinitions
{
    [Binding]
    public sealed class SearchOnYoutubeStepDefinitions 
    {
        public IWebDriver driver;
        public SearchOnYoutubeStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        //[Given(@"Open the browser")]
        //public void GivenOpenTheBrowser()
        //{
        //    driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //}

        //[When(@"Go to Youtube")]
        //public void WhenGoToYoutube()
        //{
        //    driver.Url = "https://www.youtube.com/";
        //    Thread.Sleep(1000);
        //}

        [When(@"Search Because Its Interesting")]
        public void WhenSearchBecauseItsInteresting()
        {
            HomePage HP = new HomePage(driver);
            HP.SearchYoutube("Because Its Interesting");
        }

        [Then(@"Because Its Interesting channel should be displayed")]
        public void ThenBecauseItsInterestingChannelShouldBeDisplayed()
        {
            //IWebElement VerifySearch = driver.FindElement(By.XPath("//*[contains(text(),'Latest from Because')]"));
            //if (VerifySearch.Displayed)
            //    Console.WriteLine(VerifySearch.Text);
            //else
            //    Console.WriteLine("Channel Not Found");
            Assert.True(driver.Title.Contains("Because Its Interesting"));
        }

    }
}
