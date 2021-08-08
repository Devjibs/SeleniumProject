using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumProject
{
    public class SimpleAppRunner
    {
        public static void Main(string[] args)
        {
            new DriverManager().SetUpDriver(new ChromeConfig());

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
            //Go to github and search for my username 
            driver.Navigate().GoToUrl("https://github.com");

            List<string> searchPhrase = new List<string>();
            searchPhrase.AddRange(new List<string> { "jibogithub", "iphone" });

            List<string> searchSelectors = new List<string>();
            searchSelectors.AddRange(new List<string> { "[name = 'q']", "[name='field-keywords']" });


            IWebElement searchInputGithub = driver.FindElement(By.CssSelector(searchSelectors[0]));
            searchInputGithub.SendKeys(searchPhrase.FirstOrDefault());
            searchInputGithub.SendKeys(Keys.Enter);

            //Go to amazon and search for iphone
            driver.Navigate().GoToUrl("https://www.amazon.com/");
            IWebElement searchInput = driver.FindElement(By.CssSelector(searchSelectors[1]));
            searchInput.SendKeys(searchPhrase[1]);
            searchInput.SendKeys(Keys.Enter);
            
            //driver.Quit();
        }
    }
}
