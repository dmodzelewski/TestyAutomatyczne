using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace DM_POPSelWO.TestCases
{
    class dmtest
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.wsb.pl/";
            driver.Manage().Window.Maximize();


            var homePage = new Pages.HomePage();
            var loginPage = new Pages.LoginPage();
            var pulpit = new Pages.Pulpit();

            PageFactory.InitElements(driver, homePage);
            PageFactory.InitElements(driver, loginPage);
            PageFactory.InitElements(driver, pulpit);

            homePage.Login.Click();

            loginPage.UserName.SendKeys("gdx133599");
            loginPage.Password.SendKeys("Darksouls132465");
            loginPage.Submit.Click();  

            Assert.AreEqual(pulpit.Name.Text,"Modzelewski");

            pulpit.LogOut.Click();

            driver.Quit();

            

           
        }
    }
}
