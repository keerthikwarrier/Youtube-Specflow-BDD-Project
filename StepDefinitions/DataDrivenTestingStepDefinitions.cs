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

        /* These 2 Step def use the Table set in Class "ChannelTestData". 
          We can use the Data in Data Tables using foreach so it execute all the Data sets */
        [When(@"Search the Channel on Youtube search")]
        public void WhenSearchTheChannelOnYoutubeSearch(Table table)
        {
            HomePage HP = new HomePage(driver);
            var SearchCriteria = table.CreateSet<ChannelTestData>();
            foreach (var item in SearchCriteria)
            {
                HP.SearchYoutube(item.ChannelSearch);
            }

        }

        [Then(@"Verify the search displays the Channel")]
        public void ThenVerifyTheSearchDisplaysTheChannel(Table table)
        {
            HomePage HP = new HomePage(driver);
            var SearchCriteria = table.CreateSet<ChannelTestData>();
            foreach (var item in SearchCriteria)
            {
                HP.SearchResultsFound(item.ChannelFound);
            }
        }

    }
    /* This Data table is created for setting multiple data sets */
    public class ChannelTestData
    {
        public string ChannelSearch { get; set; }
        public string ChannelFound { get; set; }
    }
}

