using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using AutoTest.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using System.Linq;

namespace AutoTest
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("Search features")] // ПОметка тест набора
    [AllureFeature("Search features")]
    public class TestSearch : BaseTest
    {


        [Test(Description = "Control test if test was FAIL")]
        public void TEST_fail()
        {
            MainPage main = new MainPage(driver);
            Assert.AreEqual("TExt", main.makeSearch("Irlix").res());
        }

        [Test(Description = "Тест поиска вакансии по компании - Positive")]
        [AllureStory("Valid search on company")]
        [AllureStep("Valid search on company")]
        [AllureTag("Regression")]
         public void TEST_SearchVacancyOnCompany()
        {
           MainPage main = new MainPage(driver);
         //   Console.WriteLine(text);
          //  Assert.IsTrue(main.makeSearch("Google").result().Contains("«google»"));
            Assert.IsTrue(main.makeSearch("Google").listElements.Count()>1);
        }

        [Test(Description = "Тест поиска вакансии по компании - Negative")]
        [AllureStory("Invalid search on company")]
        [AllureStep("Invalid search on company")]
        [AllureTag("Regression")]
        public void TEST_SearchVacancyOnCompany2()
        {
            MainPage main = new MainPage(driver);
            //   Console.WriteLine(text);
            Assert.AreEqual("По запросу «фыувыввы» ничего не найдено", main.makeSearch("фыувыввы").result());
        }


        [Test(Description = "Тест открытия страницы расширенного поиска")] // Тест открытия страницы расширенного поиска. 
        [AllureStory("Open advance search page")]
        [AllureStep("Open advance search page")]
        [AllureTag("Regression")]
        public void TEST_3()
        {
            string textHeader = new MainPage(driver).openAdvancePage().headerText();
            Assert.AreEqual("Поиск вакансий", textHeader);

        }
    }
}
