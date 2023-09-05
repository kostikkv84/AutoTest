using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace AutoTest.PageObjects
{
    public class BasePage
    {

       protected IWebDriver driver;
       

        public BasePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

    }
}
