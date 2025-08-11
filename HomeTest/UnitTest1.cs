using HomeTest.Task1Pages;
using HomeTest.Task2Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HomeTest
{
    public class Tests
    {
        IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.htm");
            _driver.Manage().Window.Maximize();

            RegisterPage registerPage = new RegisterPage(_driver);
            LoggedInPage loggedInPage = new LoggedInPage(_driver);

            string userName = "johndoe4";
            string password = "Pass@1233456";

            registerPage.EnterFirstName("John");
            registerPage.EnterLastName("Doe");
            registerPage.EnterAddress("123 Main Street");
            registerPage.EnterCity("Springfield");
            registerPage.EnterState("Illinois");
            registerPage.EnterZipCode("62704");
            registerPage.EnterPhone("5551234567");
            registerPage.EnterSSN("123-45-6789");
            registerPage.EnterUserName(userName);
            registerPage.EnterPasswordAndConfirm(password);
            registerPage.ClickRegisterBtn();

            System.Threading.Thread.Sleep(10000);

            loggedInPage.LogOutClick();

            registerPage.Login(userName, password);
            loggedInPage.AssertLogIn();
        }

        [Test]
        public void Test2()
        {
            _driver.Navigate().GoToUrl("https://file-examples.com/ ");
            _driver.Manage().Window.Maximize();

            VerifyPage verifyPage = new VerifyPage(_driver);
            verifyPage.ClickCheckBox();
        }

        [Test]
        public void Test3()
        {

        }

        [TearDown]
        public void TearDown()
        {
            //_driver.Dispose();
        }
    }
}