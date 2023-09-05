using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutoTest.PageObjects
{
    public class FullSearchPage : BasePage
    {

        public FullSearchPage(IWebDriver driver) : base(driver) { }

        private IWebElement headerPage => driver.FindElement(By.XPath("//h1[@data-qa=\"bloko-header-1\"]"));
       
        public string headerText()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(d => headerPage.Displayed);
            return headerPage.Text;
        }



    }
}
