using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using SpecflowProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SpecflowProject.Pages
{
    public class HomePage  
    {
        private IWebDriver driver;
        private WaitHelper wait;

        public HomePage(IWebDriver driver,WaitHelper wait)
        {
            this.driver = driver;
            this.wait = wait;

            PageFactory.InitElements(driver, this);
            
        }

        [FindsBy(How = How.Name,Using = "search_query")]
        public IWebElement SearchTextBox;

        [FindsBy(How =How.ClassName,Using = "ytSearchboxComponentSearchButton")]
        public IWebElement SearchButton;


        public void SearchYoutube(string ChannelName)
        {
            SearchTextBox.Clear();
            SearchTextBox.SendKeys(ChannelName);
            SearchButton.Click();
            wait.TitleContains(ChannelName);
        }



      
   
    }
}
