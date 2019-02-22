using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace DM_POPSelWO.Pages
{
    class LoginPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id , Using ="username")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "login_button")]
        public IWebElement Submit { get; set; }
    }
}
