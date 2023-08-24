using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assngmt2
{
    public class Homepage
    {
        public IWebDriver driver;
        public Homepage(WebDriver go)
        {
            driver = go;
            
        }

        public IWebElement Signup => driver.FindElement(By.PartialLinkText("Signup"));

        public void clickSignup() => Signup.Click();
    }
    

}
