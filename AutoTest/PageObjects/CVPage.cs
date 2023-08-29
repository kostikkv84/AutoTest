using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.PageObjects
{ 
    internal class CVPage : BasePage
    {
        public CVPage(IWebDriver driver) : base(driver) { }

        private IWebElement CVHeader => driver.FindElement(By.XPath("//h1[@data-qa=\"bloko-header-1\"]"));

        public string getHeader()
        {
            return CVHeader.Text;
        }
    }
}
