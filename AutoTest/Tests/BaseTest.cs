using Allure.Commons;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest
{

    public class BaseTest
    {
        public static string igWorkDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location); // рабочий каталог, относительно исполняемого файла (в нашем случае относительно DLL)

        protected IWebDriver driver;

        public object AllureLifecircle { get; private set; }

        [OneTimeSetUp] // вызывается перед началом запуска всех тестов
        public void OneTimeSetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignore-ssl-errors");
            driver = new ChromeDriver(igWorkDir, options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //   driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);

        }

        [OneTimeTearDown] //вызывается после завершения всех тестов
        public void OneTimeTearDown()
        {
            driver.Close();
        }

        [SetUp] // вызывается перед каждым тестом
        public void SetUp()
        {
            driver.Navigate().GoToUrl("http://hh.ru");
        }

        [TearDown] // вызывается после каждого теста
        public void TearDown()
        {
            if(TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                byte[] content = ((ITakesScreenshot)driver).GetScreenshot().AsByteArray;
                AllureLifecycle.Instance.AddAttachment("Failed screenshot", "image/png", content);
                Console.WriteLine("some text");
            }
        }



    }
}






