using OpenQA.Selenium;
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
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath,Using = "//input[@id='search']")]
        public IWebElement SearchTextBox;

        public void SearchYoutube(string ChannelName)
        {
            SearchTextBox.SendKeys(ChannelName);
            SearchTextBox.Submit();                
        }


    }
}
