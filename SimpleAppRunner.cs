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
            driver.Navigate().GoToUrl("https://github.com");

            IWebElement searchInput = driver.FindElement(By.CssSelector("[name = 'q']"));
            searchInput.SendKeys("jibogithub");
            searchInput.SendKeys(Keys.Enter);

            driver.Quit();
        }
    }
}
