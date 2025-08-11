using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTest.Task1Pages
{
    public class LoggedInPage
    {
        private readonly IWebDriver _driver;

        public LoggedInPage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement LogOutLink => _driver.FindElement(By.LinkText("Log Out"));

        public void LogOutClick()
        {
            LogOutLink.Click();
        }

        public void AssertLogIn()
        {
            Assert.IsTrue(LogOutLink.Displayed, "you are not logged in becuse there is no logout link");
        }
    }
}
