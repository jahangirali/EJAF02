using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EJAF.UI02
{
    public class PickFlightsPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[class='flight-panels']");

        public PickFlightsPage(IWebDriver driver) 
        {
            Driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "label[for='flexi-fares-checkbox'] span[class='checkbox']")] private IWebElement ShowFlexiFlight;
        [FindsBy(How = How.CssSelector, Using = "button[ng-click='ShowChangeSearch()']")] private IWebElement ChangeSearchLink;
        [FindsBy(How = How.CssSelector, Using = "div[class^='funnel-flight outbound']")] private IWebElement OutboundGrid;
        [FindsBy(How = How.CssSelector, Using = "div[class^='funnel-flight return']")] private IWebElement InboundGrid;
        [FindsBy(How = How.CssSelector, Using = "button[ng-click='ContinueButtonClick($event)']")] private IWebElement ContinueButton;

        public void ClickContinueButton()
        {
            ContinueButton.Click();
        }
    }
}
