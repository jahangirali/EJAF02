using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace EJAF.UI02
{
    public class TestBase
    {
        public IWebDriver Driver { get; set; }

        [OneTimeSetUp]



        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver?.Quit();
        }
    }
}
