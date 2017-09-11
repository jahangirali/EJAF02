using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EJAF.UI02.Pages
{
    public class SearchPodPage
    {
        private IWebDriver Driver { get; set; }

        [FindsBy(How = How.Id, Using = "close-drawer-link")] private IWebElement CloseCookiePolicy;



        public void ClickCloseCookiePolicy()
        {
            CloseCookiePolicy.Click();
            return;
        }
    }
}
