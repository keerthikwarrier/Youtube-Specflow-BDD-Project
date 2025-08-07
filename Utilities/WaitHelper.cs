using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SpecflowProject.Utilities
{
    public class WaitHelper
    {
        private readonly IWebDriver _driver;

        public WaitHelper(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement WaitUntilElementVisible(By by, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public IWebElement WaitUntilElementClickable(By by, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public bool WaitUntilElementInvisible(By by, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        }
        public bool TitleContains(string Title, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.TitleContains(Title));
        }
    }
}

