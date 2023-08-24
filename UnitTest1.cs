using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V113.CSS;
using OpenQA.Selenium.Support.UI;
using System.Text;

namespace Assngmt2
{
    
    public class Tests
    {
        public WebDriver browser;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximize");
            browser = new ChromeDriver(options);
            browser.Navigate().GoToUrl(LINK.POMurl);



        }

        [Test]
        public void POM()
        {
            Homepage homepage = new Homepage(browser);
            homepage.clickSignup();
            //Open open = new Open(browser);
            //open.IJavaScriptExecutor(js);

            Signup signup = new Signup(browser);
            signup.fillSignupform("lanre", $"june{new Random().Next(1, 999)}@yahoo.com");
            
            Enteracctinfo enteracctinfo = new Enteracctinfo(browser);
            enteracctinfo.FillEnteracctinfo("dende", "1", "June", "1991", "kuku", "Bebe", 
                "Deroyal nig ltd", "no2 leekki", "lAGOS", "Canada", "Ontairo", "London", "RM10", "075869320");
        }

        [TearDown]
        public void Teardown() 
        {
        
        
        
        
        }

    }


    


    }