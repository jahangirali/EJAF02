using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EJAF.UI02
{
    public class SearchPodPage
    {
        
        private IWebDriver Driver { get; set; }

        public SearchPodPage(IWebDriver driver)
        {
            Driver = driver;
        }

        //[FindsBy(How = How.Id, Using = "close-drawer-link")] private IWebElement CloseCookiePolicy;
        
        [FindsBy(How = How.CssSelector, Using = "label[for='one-way'] span[class='checkbox-label-text']")] private IWebElement OneWayCheckBox;
        [FindsBy(How = How.ClassName, Using = "origin")] private IWebElement FromAirport;
        [FindsBy(How = How.ClassName, Using = "destination")] private IWebElement ToAirport;
        [FindsBy(How = How.CssSelector, Using = "div[class='outbound-date-picker'] div[class='route-date-picker-control']")] private IWebElement DepartureDate;
        [FindsBy(How = How.CssSelector, Using = "div[class='return-date-picker'] div[class='route-date-picker-control']")] private IWebElement ReturnDate;
        [FindsBy(How = How.CssSelector, Using = "button[class*='search-submit']")] private IWebElement SearchFlight;
        [FindsBy(How = How.CssSelector, Using = "input[name='Adults']")] private IWebElement NoOfAdults;
        [FindsBy(How = How.CssSelector, Using = "input[name='Children']")] private IWebElement NoOfChildren;
        [FindsBy(How = How.CssSelector, Using = "input[id^='Infants']")] private IWebElement NoOfInfants;

        
        public void ClickOneWayCheckBox()
        {
            OneWayCheckBox.Click();
        }

        public void ClickShowFlightsButton()
        {
            SearchFlight.Click();
        }

    }
}
