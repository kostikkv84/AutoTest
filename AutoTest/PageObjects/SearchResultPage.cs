using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.PageObjects
{
    public class SearchResultPage : BasePage
    {
        public SearchResultPage(IWebDriver driver) : base(driver) { } // Конструктор страницы

        private IWebElement headerResult => driver.FindElement(By.XPath("//h1[@data-qa=\"bloko-header-3\"]"));
        private IWebElement headerResultFail => driver.FindElement(By.XPath("//h1[@data-qa=\"bloko-header-8\"]"));
        public IList<IWebElement> listElements => driver.FindElements(By.XPath("//div[@data-qa=\"vacancy-serp__results\"]//a[@class=\"serp-item__title\"]")); 
     
        
        public string result()
        {
            string text = headerResult.Text;
            return text;
        }

        public string res()
        {
            return headerResultFail.Text;
        } 

    }
}
