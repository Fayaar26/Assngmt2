using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assngmt2
{
    public static class Open
    {
        public static void IJavaScriptExecutor(this IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor JS = (IJavaScriptExecutor)driver;
            JS.ExecuteScript("arguments[0].click();", element);
        }

        public static void IJavaScriptExecutor2(this IWebElement element, IWebDriver driver, string value)
        {
            IJavaScriptExecutor JS = (IJavaScriptExecutor)driver;
            JS.ExecuteScript($"arguments[0].value = '{value}';", element);
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("arguments[0].value ='bisola'",);
        }
    }
}
