using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assngmt2
{

    public class Enteracctinfo
    {
        IWebDriver driver;
        public Enteracctinfo(WebDriver go)
        {
            driver = go;         
        }

        IWebElement input => driver.FindElements(By.TagName("input"))[1];
        IWebElement password => driver.FindElement(By.Id("password"));
        //   IWebElement days => driver.SelectElement daydown = new SelectElement(browser.FindElement(By.Id("days")));
        ////    daydown.SelectByText("10")

        IWebElement days => driver.FindElement(By.Id("days"));
        IWebElement month => driver.FindElement(By.Id("months"));
        IWebElement year => driver.FindElement(By.Id("years"));

        IWebElement first_name => driver.FindElement(By.XPath("//input[@data-qa='first_name']"));
        IWebElement last_name => driver.FindElement(By.XPath("//input[@data-qa='last_name']"));
        IWebElement company => driver.FindElement(By.XPath("//input[@data-qa='company']"));
        IWebElement address => driver.FindElement(By.XPath("//input[@data-qa='address']")); 
        IWebElement address2 => driver.FindElement(By.XPath("//input[@data-qa='address2']"));
        IWebElement country => driver.FindElement(By.Id("country"));
        //    SelectElement countrydown = new SelectElement(browser.FindElement(By.Id("country")));
        //    countrydown.SelectByText("New Zealand");
        IWebElement state => driver.FindElement(By.XPath("//input[@data-qa='state']"));
        IWebElement city => driver.FindElement(By.XPath("//input[@data-qa='city']"));
        IWebElement zipcode => driver.FindElement(By.XPath("//input[@data-qa='zipcode']"));
        IWebElement mobile_number => driver.FindElement(By.XPath("//input[@data-qa='mobile_number']"));
        IWebElement createacct => driver.FindElement(By.CssSelector("button[data-qa='create-account']"));



        public void FillEnteracctinfo(string Password, string Days, string Month, string Year, string First_name, string Last_name,
            string Company, string Address, string Address2, string Country, string State, string City, string Zipcode,string Mobile_number)
        {
            input.Click();
            password.SendKeys(Password);
            days.SendKeys(Days);
            month.SendKeys(Month);
            year.SendKeys(Year);
            first_name.SendKeys(First_name);
            last_name.SendKeys(Last_name);
            company.SendKeys(Company);
            address.SendKeys(Address);
            address2.SendKeys(Address2);
            country.SendKeys(Country);
            state.SendKeys(State);
            city.SendKeys(City);
            zipcode.SendKeys(Zipcode);
            mobile_number.SendKeys(Mobile_number);
            createacct.Click();
           






        }


    }
}
