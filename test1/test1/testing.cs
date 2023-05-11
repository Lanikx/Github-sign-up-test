using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    [TestFixture]   
    public class testing
    {
        [TestCase]
        public void Testgit()
        {
            WebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.Navigate().GoToUrl("https://github.com");
            driver.Manage().Window.Maximize();
            wait.Until(d => driver.FindElement(By.XPath("//header//a[contains(text(), 'Sign up')]")));
            driver.FindElement(By.XPath("//header//a[contains(text(), 'Sign up')]")).Click();

            wait.Until(d => driver.FindElement(By.XPath("//input[@id='email']")).Displayed);
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("12adsdqw13@gmail.com");
            wait.Until(d => driver.FindElement(By.XPath("//div[@id='email-container']/div/button")).Enabled);
            driver.FindElement(By.XPath("//div[@id='email-container']/div/button")).Click();

            wait.Until(d => driver.FindElement(By.XPath("//input[@id='password']")).Displayed);
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("12adsdqw13@gmail.com");
            wait.Until(d => driver.FindElement(By.XPath("//div[@id='password-container']/div/button")).Enabled);
            driver.FindElement(By.XPath("//div[@id='password-container']/div/button")).Click();

            wait.Until(d => driver.FindElement(By.XPath("//input[@id='login']")).Displayed);
            driver.FindElement(By.XPath("//input[@id='login']")).SendKeys("adsdqw13gdasd12mailcom");
            wait.Until(d => driver.FindElement(By.XPath("//div[@id='username-container']/div/button")).Enabled);
            driver.FindElement(By.XPath("//div[@id='username-container']/div/button")).Click();

            wait.Until(d => driver.FindElement(By.XPath("//input[@id='opt_in']")).Displayed);
            driver.FindElement(By.XPath("//input[@id='opt_in']")).SendKeys("y");
            wait.Until(d => driver.FindElement(By.XPath("//div[@id='opt-in-container']/div/button")).Enabled);
            driver.FindElement(By.XPath("//div[@id='opt-in-container']/div/button")).Click();
            driver.Quit();
        }
    }
}
