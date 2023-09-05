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
            //Console.WriteLine(new TopHeaderMenuPage(driver).openCVPage().getHeader());
            Assert.AreEqual("Прокачайте свою\r\nкарьеру с экспертами", new TopHeaderMenuPage(driver).openCVPage().getHeader());
        }
        //---------------------------------------------------------------------------

        [Test(Description = "Test CV - questions & answers 1")]
        [AllureStory("Test CV - questions & answers")]
        [AllureStep("Test answers")]
        [AllureTag("Smoke")]
        public void checkAnswer1()
        {
            //new TopHeaderMenuPage(driver).openCVPage().checkAnswerQuestion();
             Assert.IsTrue(new TopHeaderMenuPage(driver).openCVPage().setQuestions("Вопрос 1"));
        }


        [Test(Description = "Test CV - questions & answers 2")]
        [AllureStory("Test CV - questions & answers")]
        [AllureStep("Test answers")]
        [AllureTag("Smoke")]
        public void checkAnswer2()
        {
            //new TopHeaderMenuPage(driver).openCVPage().checkAnswerQuestion();
            Assert.IsTrue(new TopHeaderMenuPage(driver).openCVPage().setQuestions("Вопрос 2"));
        }

        [Test(Description = "Test CV - questions & answers 3")]
        [AllureStory("Test CV - questions & answers")]
        [AllureStep("Test answers")]
        [AllureTag("Smoke")]
        public void checkAnswer3()
        {
            //new TopHeaderMenuPage(driver).openCVPage().checkAnswerQuestion();
            Assert.IsTrue(new TopHeaderMenuPage(driver).openCVPage().setQuestions("Вопрос 3"));
        }

        [Test(Description = "Test CV - questions & answers 4")]
        [AllureStory("Test CV - questions & answers")]
        [AllureStep("Test answers")]
        [AllureTag("Smoke")]
        public void checkAnswer4()
        {
            //new TopHeaderMenuPage(driver).openCVPage().checkAnswerQuestion();
            Assert.IsTrue(new TopHeaderMenuPage(driver).openCVPage().setQuestions("Вопрос 4"));
        }

        [Test(Description = "Test CV - questions & answers 5")]
        [AllureStory("Test CV - questions & answers")]
        [AllureStep("Test answers")]
        [AllureTag("Smoke")]
        public void checkAnswer5()
        {
            //new TopHeaderMenuPage(driver).openCVPage().checkAnswerQuestion();
            Assert.IsTrue(new TopHeaderMenuPage(driver).openCVPage().setQuestions("Вопрос 5"));
        }

        [Test(Description = "Test CV - questions & answers 6")]
        [AllureStory("Test CV - questions & answers")]
        [AllureStep("Test answers")]
        [AllureTag("Smoke")]
        public void checkAnswer6()
        {
            //new TopHeaderMenuPage(driver).openCVPage().checkAnswerQuestion();
            Assert.IsTrue(new TopHeaderMenuPage(driver).openCVPage().setQuestions("Вопрос 6"));
        }


        [Test(Description = "Test CV - questions & answers 6")]
        [AllureStory("Test CV - questions & answers")]
        [AllureStep("Test answers")]
        [AllureTag("Smoke")]
        public void testMentorSignUp()
        {
            //new TopHeaderMenuPage(driver).openCVPage().checkAnswerQuestion();
            Assert.IsTrue(new TopHeaderMenuPage(driver).openCVPage().hoverToMentorImage());
        }
    }
}
