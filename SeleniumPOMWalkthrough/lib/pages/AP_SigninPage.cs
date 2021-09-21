using OpenQA.Selenium;
using System.Threading;
using SeleniumPOMWalkthrough.tests.utils;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_SigninPage
    {
        private IWebDriver _seleniumDriver;
        private string _signInPageUrl = AppConfigReader.SignInPageUrl;
        private IWebElement _emailField => this._seleniumDriver.FindElement(By.Id("email"));
        private IWebElement _passwordField => this._seleniumDriver.FindElement(By.Id("passwd"));
        private IWebElement _signinButton => this._seleniumDriver.FindElement(By.Id("SubmitLogin"));
        private IWebElement _signinAlert => this._seleniumDriver.FindElement(By.ClassName("alert"));
        private IWebElement _forgotPasswordLink => this._seleniumDriver.FindElement(By.LinkText("Forgot your password?"));
        private IWebElement _createAccountAlert => this._seleniumDriver.FindElement(By.Id("create_account_error"));
        private IWebElement _createAccountButton => this._seleniumDriver.FindElement(By.Name("SubmitCreate"));
        private IWebElement _createAccountFormField => this._seleniumDriver.FindElement(By.Name("email_create"));

        public AP_SigninPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        public void VisitSignInPage() => _seleniumDriver.Navigate().GoToUrl(_signInPageUrl);
        public void InputEmailLogin(string email) => _emailField.SendKeys(email);
        public void InputPasswordLogin(string password) => _passwordField.SendKeys(password);
        public void ClickSignin() => _signinButton.Click();
        public string GetAltertText() => _signinAlert.Text;
        public void ClickCreateEmailField() => _createAccountFormField.Click();
        public void InputEmailToCreateAccount(string email) => _createAccountFormField.SendKeys(email);
        public void ClickCreateAccountButton() => _createAccountButton.Click();
        public void ClickForgotPasswordLink() => _forgotPasswordLink.Click();

        public void InputSignInCredentials(Credentials credentials)
        {
            _emailField.SendKeys(credentials.Email);
            _passwordField.SendKeys(credentials.Password);
        }

        public string GetAlertTextCreateAccount()
        {
            Thread.Sleep(5000);
            return _createAccountAlert.Text;
        }
    }
}
