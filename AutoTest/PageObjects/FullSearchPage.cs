using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.PageObjects
{
    public class FullSearchPage : BasePage
    {

        public FullSearchPage(IWebDriver driver) : base(driver) { }

        private IWebElement headerPage => driver.FindElement(By.XPath("//h1[@data-qa=\"bloko-header-1\"]"));

        public string headerText()
        {
            string headerText = headerPage.Text;
            return headerText;
        }

    }
}
