using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix_E2E.Pages
{
    class SignUpPlanIntermediatePage
    {
        private static By continueButton = By.CssSelector("button[class='Tappable-inactive nf-btn nf-btn-primary nf-btn-solid nf-btn-oversize']");
        IWebDriver webDriver;

        public SignUpPlanIntermediatePage(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        public void ClickToContinue()
        {
            webDriver.FindElement(continueButton).Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
    }
}
