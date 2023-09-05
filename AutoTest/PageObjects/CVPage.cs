using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTest.PageObjects
{ 
    internal class CVPage : BasePage
    {
        public CVPage(IWebDriver driver) : base(driver) { }

   
        private IWebElement CVHeader => driver.FindElement(By.XPath("//h1[@data-qa=\"bloko-header-1\" and contains(text(),\"Прокачайте свою \")]"));
        private IWebElement mentorImage => driver.FindElement(By.XPath("//div[contains(@class,\"___mentor-photo\")]"));
        private IList<IWebElement> mentorImageList => driver.FindElements(By.XPath("//div[contains(@class,\"___mentor-photo\")]"));

        private IWebElement mentorInfo => driver.FindElement(By.XPath("//div[@class=\"bloko-text bloko-text_large\"]/div[contains(@class,\"mentor-position\")]"));
        private IWebElement mentorSignUpButton => driver.FindElement(By.XPath("(//button[@class=\"bloko-button bloko-button_kind-primary bloko-button_stretched\"]/span)[2]"));
        
        
        // --------------------------------------------------
      //----- Вопросы
        private IWebElement questions1 => driver.FindElement(By.XPath("//div[@class=\"bloko-text bloko-text_extra-large bloko-text_strong\" and contains(text(),\"Как выглядит процесс подготовки резюме\")]"));
        private IWebElement questions2 => driver.FindElement(By.XPath("//div[@class=\"bloko-text bloko-text_extra-large bloko-text_strong\" and contains(text(),\"могу попросить эксперта внести правки\")]"));
        private IWebElement questions3 => driver.FindElement(By.XPath("//div[@class=\"bloko-text bloko-text_extra-large bloko-text_strong\" and contains(text(),\"Какие темы можно обсудить\")]"));
        private IWebElement questions4 => driver.FindElement(By.XPath("//div[@class=\"bloko-text bloko-text_extra-large bloko-text_strong\" and contains(text(),\"Когда будет интервью\")]"));
        private IWebElement questions5 => driver.FindElement(By.XPath("//div[@class=\"bloko-text bloko-text_extra-large bloko-text_strong\" and contains(text(),\"Если оплачу услугу,\")]"));
        private IWebElement questions6 => driver.FindElement(By.XPath("//div[@class=\"bloko-text bloko-text_extra-large bloko-text_strong\" and contains(text(),\"Что делать, если меня не\")]"));
      
        
        //---- Ответы фактические
        private IWebElement answer1 => driver.FindElement(By.XPath("//div[@class=\"bloko-text bloko-text_extra-large bloko-text_strong\" and contains(text(),\"Как выглядит процесс подготовки резюме\")]/parent::*/following-sibling::div"));
        private IWebElement answer2 => driver.FindElement(By.XPath("//div[@class=\"bloko-text bloko-text_extra-large bloko-text_strong\" and contains(text(),\"могу попросить эксперта внести правки\")]/parent::*/following-sibling::div"));
        private IWebElement answer3 => driver.FindElement(By.XPath("//div[@class=\"bloko-text bloko-text_extra-large bloko-text_strong\" and contains(text(),\"Какие темы можно обсудить\")]/parent::*/following-sibling::div"));
        private IWebElement answer4 => driver.FindElement(By.XPath("//div[@class=\"bloko-text bloko-text_extra-large bloko-text_strong\" and contains(text(),\"Когда будет интервью\")]/parent::*/following-sibling::div"));
        private IWebElement answer5 => driver.FindElement(By.XPath("//div[@class=\"bloko-text bloko-text_extra-large bloko-text_strong\" and contains(text(),\"Если оплачу услугу,\")]/parent::*/following-sibling::div"));
        private IWebElement answer6 => driver.FindElement(By.XPath("//div[@class=\"bloko-text bloko-text_extra-large bloko-text_strong\" and contains(text(),\"Что делать, если меня не\")]/parent::*/following-sibling::div"));
      
        
        //---- Ответы ожидаемые
        private String answer1expected = "выбираете карьерного эксперта";
        private String answer2expected = "дней после того, как эксперт пришлёт первую версию.";
        private String answer3expected = "какие профессии сейчас наиболее перспективны и востребованы";
        private String answer4expected = "Чтобы забронировать время, нужно выбрать дату, прикрепить резюме";
        private String answer5expected = "Напишите нам на почту:";
        private String answer6expected = "Уверены, что всё разрешится.";


        //-------- Questions -----  
        private IWebElement question0 => driver.FindElement(By.XPath("//div[@id=\"accordion__heading-0\"]"));

        public string getHeader()
        {
            Console.WriteLine(CVHeader.Text);
            return CVHeader.Text;
        }

        public void qAq()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(questions1);
            actions.Perform();

            Thread.Sleep(5000);
        }

        public bool checkAnswerQuestion(IWebElement question, String expectedAnswer, IWebElement actualAnswer)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(question);
            actions.Perform();
            question.Click();
            Thread.Sleep(5000);

            return actualAnswer.Text.Contains(expectedAnswer);
        }

        public bool setQuestions(String setQuestion) {
            switch (setQuestion)
            {
                case "Вопрос 1":
                    return checkAnswerQuestion(questions1, answer1expected, answer1);
                case "Вопрос 2":
                    return checkAnswerQuestion(questions2, answer2expected, answer2);
                case "Вопрос 3":
                    return checkAnswerQuestion(questions3, answer3expected, answer3);
                case "Вопрос 4":
                    return checkAnswerQuestion(questions4, answer4expected, answer4);
                case "Вопрос 5":
                    return checkAnswerQuestion(questions5, answer5expected, answer5);
                case "Вопрос 6":
                    return checkAnswerQuestion(questions6, answer6expected, answer6);
                default:
                    return false;
            }
        }

        public bool hoverToMentorImage()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(mentorImage);
            action.Perform();
            action.ClickAndHold(mentorImage).MoveByOffset(50,0).Perform();

            Boolean is_email_visible = mentorSignUpButton.Displayed;
            Console.WriteLine(mentorSignUpButton.Text);
            Thread.Sleep(5000);
            return is_email_visible;
        }
        
    }
}
