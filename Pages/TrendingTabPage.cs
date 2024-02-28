using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowProject.Pages
{
    public class TrendingTabPage
    {
        IWebDriver driver;
        public TrendingTabPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//ytd-video-renderer)[1]//a[@id='thumbnail']")]
        public IWebElement MostTrendingVideo;

        [FindsBy(How = How.XPath, Using = "//div[@id='movie_player']")]
        public IWebElement PlayTheMostTrendingVideo;

        public void ClickOntheMostTrendingVideo()
        {
            Thread.Sleep(1000);
            MostTrendingVideo.Click();
        }
        public void VerifyTheTrendingVideoPlayed()
        {
            if(PlayTheMostTrendingVideo.Displayed)
                Console.WriteLine("The Trending video is played");
            else
                Console.WriteLine("The Trending video is not played");

        }


    }
}
