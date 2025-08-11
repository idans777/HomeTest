using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTest.Task2Pages
{
    public class VerifyPage
    {
        private readonly IWebDriver _driver;

        public VerifyPage(IWebDriver driver)
        {
            _driver = driver;
        }

        WebDriverWait Wait => new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        //IWebElement Checkbox => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input[type='checkbox']")));

        public void ClickCheckBox()
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("label.cb-lb input[type='checkbox']"))).Click();
        }
    }
}
