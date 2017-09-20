using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace EJAF.UI02.Pages
{

    public class CookiePolicyDrawer
    
    {
       
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.Id("drawer-dialog");

        public CookiePolicyDrawer(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            Driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "button[ng-click='DoAcceptCookiePolicy()']")] private IWebElement CloseCookiePolicy;




        public void ClickCloseCookiePolicy()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            CloseCookiePolicy.Click();
        }
    }
}
