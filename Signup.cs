using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V113.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assngmt2
{

    public class Signup 
    {
         IWebDriver driver;
        CustomMethods customMethods;
        public Signup(WebDriver go)
        {
            driver = go; 
            customMethods = new CustomMethods();
        }


        IWebElement Name => driver.FindElement(By.XPath("//input[@placeholder='Name']")); 
        IWebElement Signupemail => driver.FindElement(By.XPath("//input[@data-qa='signup-email']")); 
        IWebElement Signupbtn => driver.FindElement(By.CssSelector("[data-qa='signup-button']"));
        IWebElement TitleComponet => driver.FindElement(By.CssSelector("div[class='clearfix']"));





        public void fillSignupform(string name, string signup)
        {
            Name.SendKeys(name);
            Signupemail.SendKeys(signup);
            Signupbtn.IJavaScriptExecutor(driver);
            customMethods.WaitForElementby2(TitleComponet);
        }
    }
}
