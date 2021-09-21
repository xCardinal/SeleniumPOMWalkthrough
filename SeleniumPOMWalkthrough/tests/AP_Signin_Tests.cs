//using NUnit.Framework;
//using SeleniumPOMWalkthrough.lib;
//using OpenQA.Selenium.Chrome;
//using System.Threading;

//namespace SeleniumPOMWalkthrough.tests
//{
//    public class AP_SignIn_Tests
//    {
//        // We are now going to need to instantiate our pages in our test
//        // Theses classes will include all functionality for the pages but we
//        // will see that later. Don't need to use 'using' statement around tests.
//        public AP_Website<ChromeDriver> AP_Website { get; } = new AP_Website<ChromeDriver>();


//        //Our test for checking we land on the sign in page.
//        [Test]
//        public void GivenIAmOnTheHomePage_WhenIClickTheSigninButton_ThenIShouldLandOnTheSigninPage()
//        {
//            //Navigate to Automation Practice Home Page
//            AP_Website.AP_HomePage.VisitHomePage();
//            //Navigate to Automation Practice Signin Page
//            AP_Website.AP_HomePage.VisitSignInPage();
//            //Check wether the title of the page contains "Login - My Store"
//            Assert.That(AP_Website.SeleniumDriver.Title, Does.Contain("Login - My Store"));
//        }

//        [Test]
//        public void GivenIAmOnTheSigninPage_AndIEnterA4DigitPassword_WhenIClickTheSignInButton_ThenIGetAnErrorMessage()
//        {
//            AP_Website.AP_SigninPage.VisitSignInPage();
//            AP_Website.AP_SigninPage.InputEmailLogin("testing@snailmail.ccm");
//            AP_Website.AP_SigninPage.InputPasswordLogin("four");
//            AP_Website.AP_SigninPage.ClickSignin();
//            Assert.That(AP_Website.AP_SigninPage.GetAltertText().Contains("Invalid password."));
//        }

//        [Test]
//        public void GivenIAmOnTheSignInPage_WhenIEnterAnInvalieEmailAddress_AndClickCreateAnAccount_ThenIShouldReceiveAnErrorMessage()
//        {
//            AP_Website.AP_SigninPage.VisitSignInPage();
//            AP_Website.AP_SigninPage.ClickCreateEmailField();
//            AP_Website.AP_SigninPage.InputEmailToCreateAccount("testing");
//            AP_Website.AP_SigninPage.ClickCreateAccountButton();
//            Thread.Sleep(5000);
//            Assert.That(AP_Website.AP_SigninPage.GetAlertTextCreateAccount(), Does.Contain("Invalid email address."));
//        }

//        [Test]
//        public void GivenIAmOnTheSignInPage_WhenIClickTheForgotPasswordLink_ThenIShouldArriveOnTheResetPassPage()
//        {
//            AP_Website.AP_SigninPage.VisitSignInPage();
//            AP_Website.AP_SigninPage.ClickForgotPasswordLink();
//            Assert.That(AP_Website.SeleniumDriver.Title, Is.EqualTo("Forgot your password - My Store"));
//        }

//        [OneTimeTearDown]
//        public void CleanUp()
//        {
//            AP_Website.SeleniumDriver.Quit();
//            AP_Website.SeleniumDriver.Dispose();
//        }
//    }
//}
