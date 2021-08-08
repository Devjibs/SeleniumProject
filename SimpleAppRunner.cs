using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            IWebElement searchInputGithub = driver.FindElement(By.CssSelector("[name = 'q']"));
            searchInputGithub.SendKeys("jibogithub");
            searchInputGithub.SendKeys(Keys.Enter);

            //Go to amazon and search for iphone
            driver.Navigate().GoToUrl("https://www.amazon.com/");
            IWebElement searchInput = driver.FindElement(By.CssSelector("[name='field-keywords']"));
            searchInput.SendKeys("iphone");
            searchInput.SendKeys(Keys.Enter);
            
            driver.Quit();
        }
    }
}
