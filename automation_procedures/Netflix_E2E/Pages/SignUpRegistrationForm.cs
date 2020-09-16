using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix_E2E.Pages
{
    class SignUpRegistrationForm
    {
        private static By passwordInput = By.CssSelector("input[name='password']");
        private static By continueButton = By.XPath("//*[@id='appMountPoint']/div/div/div[2]/div/form/div/div[4]/button");
        IWebDriver webDriver;

        public SignUpRegistrationForm(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        public void EnterPassword(string password)
        {
            webDriver.FindElement(passwordInput).Click();
            webDriver.FindElement(passwordInput).SendKeys(password);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void ClickToContinue()
        {
            webDriver.FindElement(continueButton).Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
    }
}
