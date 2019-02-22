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
    class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using =("//div/*[contains(@class, 'top-menu')]/ul/li[3]/a"))]
        public IWebElement Login { get; set; }

    }
}
