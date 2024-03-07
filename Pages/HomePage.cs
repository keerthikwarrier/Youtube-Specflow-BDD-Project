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
    public class HomePage  
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        [FindsBy(How = How.XPath,Using = "//input[@id='search']")]
        public IWebElement SearchTextBox;

        [FindsBy(How = How.XPath, Using = "//yt-formatted-string[text()='Trending']")]
        public IWebElement TrendingTab;

        public void SearchYoutube(string ChannelName)
        {
            SearchTextBox.Clear();
            SearchTextBox.SendKeys(ChannelName);
            SearchTextBox.Submit();
        }

        public void GoToTrendingPage()
        {
            TrendingTab.Click();          
        }
      
        public void SearchResultsFound(string ChannelFound)
        {
            Assert.True(driver.Title.Contains(ChannelFound));
        }
    }
}
