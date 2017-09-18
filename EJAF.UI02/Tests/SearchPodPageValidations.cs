using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
        }
        

        [Test]
        public void NoDepartureAirport()
        {
            var searchPodPage = new SearchPodPage(Driver);

            searchPodPage.ClickOneWayCheckBox();

        }

        [TearDown]
        public void OneTimeTearDown()
        {
            //Driver?.Quit();
        }

    }
}
