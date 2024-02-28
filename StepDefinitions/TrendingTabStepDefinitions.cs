using OpenQA.Selenium;
using SpecflowProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowProject.StepDefinitions
{
    [Binding]
    public sealed class TrendingTabStepDefinitions
    {

        public IWebDriver driver;
        public TrendingTabStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }


        [When(@"Go To Trending Tab from Home Page")]
        public void WhenGoToTrendingTabFromHomePage()
        {
            HomePage HP = new HomePage(driver);
            HP.GoToTrendingPage();
        }

        [When(@"Click on the most trending video on Trending page")]
        public void WhenClickOnTheMostTrendingVideoOnTrendingPage()
        {
            TrendingTabPage TrendingPage = new TrendingTabPage(driver);
            TrendingPage.ClickOntheMostTrendingVideo();
        }

        [Then(@"User should see the most trending video on the video page")]
        public void ThenUserShouldSeeTheMostTrendingVideoOnTheVideoPage()
        {
            //This Assert Verifies if the URL contains watch in it
            Assert.True(driver.Url.Contains("watch"));
            TrendingTabPage TrendingPage = new TrendingTabPage(driver);
            TrendingPage.VerifyTheTrendingVideoPlayed();

        }

    }
}
