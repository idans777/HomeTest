using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTest.Task1Pages
{
    public class RegisterPage
    {
        private readonly IWebDriver _driver;

        public RegisterPage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement FirstName => _driver.FindElement(By.Id("customer.firstName"));
        IWebElement LastName => _driver.FindElement(By.Id("customer.lastName"));
        IWebElement Address => _driver.FindElement(By.Id("customer.address.street"));
        IWebElement City => _driver.FindElement(By.Id("customer.address.city"));
        IWebElement State => _driver.FindElement(By.Id("customer.address.state"));
        IWebElement ZipCode => _driver.FindElement(By.Id("customer.address.zipCode"));
        IWebElement Phone => _driver.FindElement(By.Id("customer.phoneNumber"));
        IWebElement SSN => _driver.FindElement(By.Id("customer.ssn"));
        IWebElement UserName => _driver.FindElement(By.Id("customer.username"));
        IWebElement Password => _driver.FindElement(By.Id("customer.password"));
        IWebElement ConfirmPassword => _driver.FindElement(By.Id("repeatedPassword"));
        IWebElement RegisterBtn => _driver.FindElement(By.CssSelector("input[value='Register']"));

        IWebElement UsernameField => _driver.FindElement(By.Name("username"));
        IWebElement PasswordField => _driver.FindElement(By.Name("password"));
        IWebElement LoginBtn => _driver.FindElement(By.CssSelector("input[value='Log In']"));


        public void EnterFirstName(string input)
        {
            FirstName.SendKeys(input);
        }

        public void EnterLastName(string input)
        {
            LastName.SendKeys(input);
        }

        public void EnterAddress(string input)
        {
            Address.SendKeys(input);
        }

        public void EnterCity(string input)
        {
            City.SendKeys(input);
        }

        public void EnterState(string input)
        {
            State.SendKeys(input);
        }

        public void EnterZipCode(string input)
        {
            ZipCode.SendKeys(input);
        }

        public void EnterPhone(string input)
        {
            Phone.SendKeys(input);
        }

        public void EnterSSN(string input)
        {
            SSN.SendKeys(input);
        }

        public void EnterUserName(string input)
        {
            UserName.SendKeys(input);
        }

        public void EnterPasswordAndConfirm(string input)
        {
            Password.SendKeys(input);
            ConfirmPassword.SendKeys(input);
        }

        public void ClickRegisterBtn()
        {
            RegisterBtn.Click();
        }

        public void Login(string userName, string password)
        {
            UsernameField.SendKeys(userName);
            PasswordField.SendKeys(password);
            LoginBtn.Click();
        }
    }
}
