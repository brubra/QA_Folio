using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix_E2E.Pages
{
    class SignUpHomePage
    {
        private static By emailInput = By.CssSelector("input[name='email']");
        private static By getStartedButton = By.CssSelector("button[class='btn btn-red nmhp-cta nmhp-cta-extra-large btn-none btn-custom']");
        IWebDriver webDriver;

        public SignUpHomePage(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        public void EnterEmail(string email)
        {
            webDriver.FindElement(emailInput).Click();
            webDriver.FindElement(emailInput).SendKeys(email);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void ClickToContinue()
        {
            webDriver.FindElement(getStartedButton).Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
    }
}
