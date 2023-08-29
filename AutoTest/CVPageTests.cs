using AutoTest.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("CV features")] 
    [AllureFeature("CV features")]
    [AllureEpic("HH CV APP")]
    public class CVPageTests : BaseTest
    {

        [Test(Description = "Open CV page test on HH.RU")]
        [AllureStory("Try open CV page only")]
        [AllureStep("Open CV page")]
        [AllureTag("Smoke")]
        public void openCVPage()
        {
            Console.WriteLine(new TopHeaderMenuPage(driver).openCVPage().getHeader());
           // Assert.AreEqual("",new TopHeaderMenuPage(driver).openCVPage().getHeader());
        }


    }
}
