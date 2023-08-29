using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTest.PageObjects
{
    internal class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver){ } // конструктор страницы

        private IWebElement btnLogin => driver.FindElement(By.XPath("//a[@data-qa=\"login\"]"));
        private IWebElement searchInput => driver.FindElement(By.XPath("//input[@data-qa=\"search-input\"]"));
        private IWebElement searchBtn => driver.FindElement(By.XPath("//button[@data-qa=\"search-button\"]"));
        private IWebElement advancedSearch => driver.FindElement(By.XPath("//a[@data-qa=\"advanced-search\"]"));


        public LoginPage openLogin()
        {
                btnLogin.Click();
            return new LoginPage(driver);
        }

        public SearchResultPage makeSearch(String company)
        {
                searchInput.SendKeys(company);
                searchBtn.Click();

            return new SearchResultPage(driver);
        }

        public FullSearchPage openAdvancePage()
        {
            advancedSearch.Click();
            return new FullSearchPage(driver);
        } 

    }
}
