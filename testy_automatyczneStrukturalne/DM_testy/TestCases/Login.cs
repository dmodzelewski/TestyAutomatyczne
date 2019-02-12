using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_testy.TestCases
{
    class Login
    {
        [Test]

        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.wsb.pl/";

            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//div/*[contains(@class, 'top-menu')]/ul/li[3]/a")).Click();

            //Znajduje id  nazwę użytkownika
            driver.FindElement(By.Id("username")).SendKeys("gdx133599");

            //Znajduję id hasło 
            driver.FindElement(By.Id("password")).SendKeys("Darksouls132465");

            driver.FindElement(By.Id("login_button")).Click();
            string s = driver.FindElement(By.XPath("//div/*[contains(@id , 'user-name')]/span[1]/b")).Text;

            Assert.AreEqual(s ,"Modzelewski");

            driver.FindElement(By.XPath("//div/*[contains(@class , 'user-links ')]/span/a")).Click();

            driver.Quit();
        }
    }
}
