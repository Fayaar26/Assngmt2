using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assngmt2
{

    public class CustomMethods
    {
        public void WaitForAlertby(IWebDriver browser)
        {
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }

        public void WaitForElementby(IWebDriver browser, string by)
        {
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"div[class='{by}']")));
        }

        public Func<IWebDriver, IWebElement> WaitForElementby2(IWebElement element)
        {
            return delegate (IWebDriver driver)
            {
                try
                {
                    if (!element.Displayed)
                    {
                        return null;
                    }

                    return element;
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
            };
        }
    }
}
