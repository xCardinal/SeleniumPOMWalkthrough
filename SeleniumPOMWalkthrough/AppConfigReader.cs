using System;
using System.Configuration;

namespace SeleniumPOMWalkthrough
{
    //Lobal reader for App.config attributes
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string SignInPageUrl = ConfigurationManager.AppSettings["signinpage_url"];

    }
}
