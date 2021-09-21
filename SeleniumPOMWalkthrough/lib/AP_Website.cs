using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumPOMWalkthrough.lib.pages;
using SeleniumPOMWalkthrough.lib.driver_config;
using OpenQA.Selenium;

namespace SeleniumPOMWalkthrough.lib
{
    //Super class for all service objects
    public class AP_Website<T> where T : IWebDriver, new()
    {
        #region
        //Accessinle page objects and selenium driver
        public IWebDriver SeleniumDriver { get; set; }
        public AP_HomePage AP_HomePage { get; set; }

        public AP_SigninPage AP_SigninPage { get; set; }
        #endregion

        //Constructor for the driver and config for the service
        public AP_Website(int pageLostInSecs = 30, int implicitwaitInSecs = 30)
        {
            //instantiate the driver
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLostInSecs, implicitwaitInSecs).Driver;

            //Instantiate the page obects WITH the selenium driver
            AP_SigninPage = new AP_SigninPage(SeleniumDriver);
            AP_HomePage = new AP_HomePage(SeleniumDriver);

        }

        //Delete cookies (optional)
        public void DeleteCookies() => SeleniumDriver.Manage().Cookies.DeleteAllCookies();
    }
}
