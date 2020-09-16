using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Netflix_E2E.Pages
{
    class SignUpPlanForm
    {
        private static By title = By.ClassName("title");
        private static By continueButton = By.XPath("//*[@id='appMountPoint']/div/div/div[2]/div/form/div/div[4]/button");
        IWebDriver webDriver;

        public SignUpPlanForm(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        public String GetFirstPlanTitle()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30000);
            List<String> titles = webDriver
                            .FindElements(title)
                            .Select(x => x.Text)
                            .ToList();

            return titles[0];
        }

        public String GetSecondPlanTitle()
        {
            List<String> titles = webDriver
                            .FindElements(title)
                            .Select(x => x.Text)
                            .ToList();

            return titles[1];
        }

        public String GetThirdPlanTitle()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30000);
            List<String> titles = webDriver
                            .FindElements(title)
                            .Select(x => x.Text)
                            .ToList();

            return titles[2];
        }
    }
}
