using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EJAF.UI02.Pages
{
    public class CookiePolicyDrawer
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.Id("drawer-dialog");

        public CookiePolicyDrawer(IWebDriver driver)
        {
            Driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "button[ng-click='DoAcceptCookiePolicy()']")] private IWebElement CloseCookiePolicy;




        public void ClickCloseCookiePolicy()
        {
            CloseCookiePolicy.Click();
        }
    }
}
