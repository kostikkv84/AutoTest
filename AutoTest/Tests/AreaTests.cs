using AutoTest.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("AreaPage features")]
    [AllureFeature("AreaPage features")]
    [AllureEpic("HH AreaPage APP")]
    internal class AreaTests : BaseTest
    {

        [Test(Description = "Проверка открытия страницы смены локации. ")]
        [AllureStory("Try open AreaPage page only")]
        [AllureStep("Open AreaPage page")]
        [AllureTag("Smoke")]
        public void checkOpenAreaSwitchPage()
        {
            Assert.IsTrue(new TopHeaderMenuPage(driver).openAreaSwitchPage().IsElementPresent(By.XPath("(//div[@class=\"bloko-text\"])[1]")));
        }

        [Test(Description = "Проверка Хедера на странице смены локации. ")]
        [AllureStory("Check HeaderText AreaPage page only")]
        [AllureStep("Check HeaderText page")]
        [AllureTag("Smoke")]
        public void checkHeaderAreaSwitchPage()
        {
            String text = new TopHeaderMenuPage(driver).openAreaSwitchPage().returnHeaderText();

            Console.WriteLine(text);
            Assert.AreEqual("Укажите город, который требуется найти:", text);
        }

    }
}
