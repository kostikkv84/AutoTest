using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.PageObjects
{
    internal class TopHeaderMenuPage : BasePage // Верхнее меню. Видно на всех страницах сайта. 
    {
        public TopHeaderMenuPage(IWebDriver driver) : base(driver) { }

        private IWebElement CVHeader => driver.FindElement(By.XPath("//a[@data-qa=\"mainmenu_expertresume\"]"));
        private IWebElement areaSwitcher => driver.FindElement(By.XPath("//button[@data-qa=\"mainmenu_areaSwitcher\"]"));

        public CVPage openCVPage()
        {
            CVHeader.Click();
            return new CVPage(driver);
        }

        public AreaSwitchPage openAreaSwitchPage()
        {
            areaSwitcher.Click();
            return new AreaSwitchPage(driver);
        }
    }
}
