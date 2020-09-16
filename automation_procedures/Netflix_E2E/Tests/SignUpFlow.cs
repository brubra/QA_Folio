using Netflix_E2E.Pages;
using Netflix_E2E.Tests;
using NUnit.Framework;
using System.Threading;

namespace Netflix_E2E
{
    public class SignUpFlow : TestBase
    {
        [Test]
        public void CheckFirstPlan()
        {
            //arrange
            SignUpHomePage inHomePage = new SignUpHomePage(driver);
            SignUpRegistrationForm inRegistrationForm = new SignUpRegistrationForm(driver);
            SignUpPlanIntermediatePage inPlanIntermediatePage = new SignUpPlanIntermediatePage(driver);
            SignUpPlanForm inPlanForm = new SignUpPlanForm(driver);
            string actualTitle = string.Empty;
            string expectedTitle = "Premium";

            //act
            driver.Navigate().GoToUrl("https://www.netflix.com/br-en/");
            inHomePage.EnterEmail("user123321@gmail.com");
            inHomePage.ClickToContinue();
            inRegistrationForm.EnterPassword("testing123testing321");
            inRegistrationForm.ClickToContinue();
            inPlanIntermediatePage.ClickToContinue();
            actualTitle = inPlanForm.GetFirstPlanTitle();

            //assert
            Assert.IsTrue(actualTitle == expectedTitle, "The first plan title on the screen is: " + actualTitle);
        }

        [Test]
        public void CheckSecondPlan()
        {
            SignUpHomePage inHomePage = new SignUpHomePage(driver);
            SignUpRegistrationForm inRegistrationForm = new SignUpRegistrationForm(driver);
            SignUpPlanIntermediatePage inPlanIntermediatePage = new SignUpPlanIntermediatePage(driver);
            SignUpPlanForm inPlanForm = new SignUpPlanForm(driver);
            string actualTitle = string.Empty;
            string expectedTitle = "Standard";

            driver.Navigate().GoToUrl("https://www.netflix.com/br-en/");
            inHomePage.EnterEmail("user123321@gmail.com");
            inHomePage.ClickToContinue();
            inRegistrationForm.EnterPassword("testing123testing321");
            inRegistrationForm.ClickToContinue();
            inPlanIntermediatePage.ClickToContinue();
            actualTitle = inPlanForm.GetSecondPlanTitle();

            Assert.IsTrue(actualTitle == expectedTitle, "The second plan title on the screen is: " + actualTitle);
        }

        [Test]
        public void CheckThirdPlan()
        {
            SignUpHomePage inHomePage = new SignUpHomePage(driver);
            SignUpRegistrationForm inRegistrationForm = new SignUpRegistrationForm(driver);
            SignUpPlanIntermediatePage inPlanIntermediatePage = new SignUpPlanIntermediatePage(driver);
            SignUpPlanForm inPlanForm = new SignUpPlanForm(driver);
            string actualTitle = string.Empty;
            string expectedTitle = "Basic";

            driver.Navigate().GoToUrl("https://www.netflix.com/br-en/");
            inHomePage.EnterEmail("user123321@gmail.com");
            inHomePage.ClickToContinue();
            inRegistrationForm.EnterPassword("testing123testing321");
            inRegistrationForm.ClickToContinue();
            inPlanIntermediatePage.ClickToContinue();
            actualTitle = inPlanForm.GetThirdPlanTitle();

            Assert.IsTrue(actualTitle == expectedTitle, "The third plan title on the screen is: " + actualTitle);
        }
    }
}