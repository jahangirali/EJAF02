using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJAF.UI02.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EJAF.UI02.Tests

{
    [TestFixture]
    public class SearchPodPageValidations
    {
        private IWebDriver Driver { get; set; }
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://www.easyjet.com");
            var cookiePolicyDrawer = new CookiePolicyDrawer(Driver);
            cookiePolicyDrawer.ClickCloseCookiePolicy();

        }
        

        [Test]
        public void SearchPodIsOneWayCheckBoxTicked()
        {
            var searchPodPage = new SearchPodPage(Driver);

            searchPodPage.ClickOneWayCheckBox();
            searchPodPage.EnterTextFromField();

            Assert.IsTrue(searchPodPage.IsOneWayCheckBoxTicked());
        }

        [Test]
        public void SearchPodShowFlights()
        {
            var searchPodPage = new SearchPodPage(Driver);
            searchPodPage.ClickOneWayCheckBox();
            searchPodPage.EnterTextToField();
            searchPodPage.ClickShowFlightsButton();
        }

        [TearDown]
        public void OneTimeTearDown()
        {
            //Driver?.Quit();
        }

    }
}
