using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V119.FedCm;
using System;
using System.Data.SqlTypes;
using TechTalk.SpecFlow;

namespace SpecflowProject.StepDefinitions
{
    [Binding]
    public sealed class SearchOnYoutubeStepDefinitions
    {
        private IWebDriver driver;
        public SearchOnYoutubeStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            //   driver = new ChromeDriver();
            //   driver.Manage().Window.Maximize();
        }

        [When(@"Go to Youtube")]
        public void WhenGoToYoutube()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(1000);
        }

        [When(@"Search Because Its Interesting")]
        public void WhenSearchBecauseItsInteresting()
        {
            IWebElement SearchBox= driver.FindElement(By.XPath("//input[@id='search']"));
            SearchBox.SendKeys("Because Its Interesting");
            SearchBox.Submit();
            Thread.Sleep(5000);
            //  driver.Quit();
        }

        [Then(@"Because Its Interesting channel should be displayed")]
        public void ThenBecauseItsInterestingChannelShouldBeDisplayed()
        {
            IWebElement VerifySearch = driver.FindElement(By.XPath("//*[contains(text(),'Latest from Because')]"));
            if (VerifySearch.Displayed)
                Console.WriteLine(VerifySearch.Text);
            else
                Console.WriteLine("Channel Not Found");
        }

        [When(@"Go to Subsriptions Tab in Youtube")]
        public void WhenGoToSubsriptionsTabInYoutube()
        {
            Thread.Sleep(3000);
            IWebElement SubsriptionsElement = driver.FindElement(By.XPath("//a[@title='Subscriptions']/span"));
            SubsriptionsElement.Click();
            Thread.Sleep(1000);
        }

        [Then(@"Signin button should be displayed")]
        public void ThenSigninButtonShouldBeDisplayed()
        {
            IWebElement Message = driver.FindElement(By.XPath("//div[text()='Don’t miss new videos']"));
            IWebElement SignIn = driver.FindElement(By.Id("button"));
            if (SignIn.Displayed)
                Console.WriteLine(Message.Text);
            else
                Console.WriteLine("Account is Already Signed In");
            Thread.Sleep(3000);
            
        }



    }
}
