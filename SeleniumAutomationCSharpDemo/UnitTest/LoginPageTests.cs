using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumAutomationCSharpDemo.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumAutomationCSharpDemo.UnitTest
{
    [TestClass]
    public class LoginPageTests : UnitTestBase
    {
        private LoginPO loginPO;
        [TestMethod]
        public void LoginPageUnitTest()
        {
            loginPO = new LoginPO(driver);
            Assert.IsTrue(loginPO.LoginFormHeader.Displayed, $"nameof{loginPO.LoginFormHeader} was not displayed.");
            
            List<IWebElement> webElements = new List<IWebElement>() { loginPO.UsernameLabel, loginPO.PasswordLabel,
            loginPO.SigninButton, loginPO.RememberMeButton};
            EachElementDisplayed(webElements);

            loginPO.UsernameInput.SendKeys("Norah");
            loginPO.PasswordInput.SendKeys("12345");
            loginPO.SigninButton.Click();
            Thread.Sleep(3000);
            Assert.IsTrue(loginPO.FinancialOvervieWholePage.Displayed, $"nameof{loginPO.FinancialOvervieWholePage}" +
                $"was not displayed.");
        }
        [TestMethod]

        public void FinancialOverviewPageUnitTests()
        {
            loginPO = new LoginPO(driver);

            loginPO.UsernameInput.SendKeys("Norah");
            loginPO.PasswordInput.SendKeys("12345");
            loginPO.SigninButton.Click();
            Thread.Sleep(3000);
            Assert.IsTrue(loginPO.FinancialOvervieWholePage.Displayed, $"nameof{loginPO.FinancialOvervieWholePage}" +
                $"was not displayed.");

            List<IWebElement> eachElement = new List<IWebElement>() { loginPO.Logo, loginPO.SearchBox, loginPO.MessageNotifications,
            loginPO.SettingsIcon, loginPO.LoggedUserPicture};

            EachElementDisplayed(eachElement);

            ElementCollectionDisplayed(loginPO.MainMenu);
            Assert.IsTrue(loginPO.TimeAlertHeader.Text.Equals("Your nearest branch closes in: 30m 5s"),
                $"The text 'Your nearest branch closes in: 30m 5s' was not displayed instead " +
                $"nameof{loginPO.TimeAlertHeader} returned.");

            Assert.IsTrue(loginPO.FinancialOverviewHeader.Text.Equals("Financial Overview"),
                $"The header 'Financial Overview' was not displayed, instead nameof{loginPO.FinancialOverviewHeader}" +
                $"returned.");

            ElementCollectionDisplayed(loginPO.ElementButtons);
            ElementCollectionDisplayed(loginPO.BalancesDisplay);
            List<string> columnHeaders = new List<string>() { "STATUS", "DATE", "DESCRIPTION", "CATEGORY", "AMOUNT" };
            CompareWebElementsToStringList(columnHeaders, loginPO.TableColumnHeaders);

            Assert.IsTrue(loginPO.RecentTransactions.Text.Equals("Recent Transactions"),
                $"The Header 'Recent Transactions' was not displayed, instead " +
                $"nameof{loginPO.RecentTransactions} returned.");
        }       
    }
}
