using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V113.Browser;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.PageObjects 
{
    internal class AreaSwitchPage : BasePage
    {
        public AreaSwitchPage(IWebDriver driver) : base(driver) {   }

        WebDriverWait wait => new WebDriverWait(driver, TimeSpan.FromSeconds(5));

        private IWebElement headerText => driver.FindElement(By.XPath("//div[@class=\"bloko-text\" and contains(text(),\"Укажите город\")]"));
        private IWebElement searchCity => driver.FindElement(By.XPath("//input[@data-qa=\"area-search-input\"]"));


        public bool IsElementPresent(By by) // Проверка наличия элемента на странице. Общий метод. 
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


        public string returnHeaderText() // получение текста Хедера
        {
            String text = headerText.Text;
            return text;
        }

        public string returnPlaceHolderText() // получение текста Хедера
        {
            String placeholder = searchCity.GetAttribute("placeholder");
            return placeholder;
        }



    }
}
