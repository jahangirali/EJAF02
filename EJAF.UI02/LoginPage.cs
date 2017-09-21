using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EJAF.UI02
{
    public class LoginPage
    {
        [FindsBy(How = How.CssSelector, Using = "class[ng-click='DoSignInClick()']")] private IWebElement SignIn;
        [FindsBy(How = How.CssSelector, Using = "button[id='close-drawer-link']")] private IWebElement CloseButton;
        [FindsBy(How = How.CssSelector, Using = "href[class='ej-link register-link']")] private IWebElement RegisterHereLink;
        [FindsBy(How = How.CssSelector, Using = "input[id='signin-username']")] private IWebElement EmailAddress;
        [FindsBy(How = How.CssSelector, Using = "input[id='signin-password']")] private IWebElement Password;
        [FindsBy(How = How.CssSelector, Using = "input[id='signin-login']")] private IWebElement SignInButton;
        [FindsBy(How = How.CssSelector, Using = "input[id='']")] private IWebElement KeepMeSignedInCheckBox;
        [FindsBy(How = How.CssSelector, Using = "input[id='']")] private IWebElement ForgottenYourDetailsLink;
       
        public void EnterEmailAddress()
        {
            
        }
        
    }
}
