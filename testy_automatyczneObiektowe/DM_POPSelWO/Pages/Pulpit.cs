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
    class Pulpit
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = ("//div/*[contains(@id , 'user-name')]/span[1]/b"))]
        public IWebElement Name { get; set; }

        
        [FindsBy(How = How.XPath, Using = ("//div/*[contains(@class , 'user-links ')]/span/a"))]
        public IWebElement LogOut { get; set; }
    }
}
