using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationCSharpDemo.PageObjects
{
    public class LoginPO
    {
        IWebDriver driver;
        public LoginPO(IWebDriver driver)
        {
            this.driver = driver;
        }public LoginPO() { }
        public IWebElement LoginFormHeader => driver.FindElement(By.XPath("//h4[@class='auth-header']"));
        public IWebElement UsernameLabel => driver.FindElement(By.XPath("//div[@class='form-group']//label[contains(text(), 'Username')]"));
        public IWebElement PasswordLabel => driver.FindElement(By.XPath("//div[@class='form-group']//label[contains(text(), 'Password')]"));
        public IWebElement UsernameInput => driver.FindElement(By.XPath("//input[@id='username']"));
        public IWebElement PasswordInput => driver.FindElement(By.XPath("//input[@id='password']"));
        public IWebElement SigninButton => driver.FindElement(By.XPath("//a[@id='log-in']"));
        public IWebElement RememberMeButton => driver.FindElement(By.XPath("//input[@class='form-check-input']"));

        //Financial Overview Page
        public IWebElement FinancialOvervieWholePage => driver.FindElement(By.XPath("//div[@class='layout-w']"));
        public ReadOnlyCollection<IWebElement> MainMenu => driver.FindElements(By.XPath("//ul[@class='main-menu']//child::li"));
        public IWebElement TimeAlertHeader => driver.FindElement(By.XPath("//h6[@id='time' and text()='Your nearest branch closes in: 30m 5s']"));
        public ReadOnlyCollection<IWebElement> ElementButtons => driver.FindElements(By.XPath("//div[@class='element-actions']//child::a"));
        public IWebElement Logo => driver.FindElement(By.XPath("//a[@class='logo']"));
        public IWebElement SearchBox => driver.FindElement(By.XPath("//div[@class='element-search autosuggest-search-activator']"));
        public IWebElement MessageNotifications => driver.FindElement(By.XPath("//div[@class='messages-notifications os-dropdown-trigger os-dropdown-position-left']"));
        public IWebElement SettingsIcon => driver.FindElement(By.XPath("//div[@class='top-icon top-settings os-dropdown-trigger os-dropdown-position-left']"));
        public IWebElement LoggedUserPicture => driver.FindElement(By.XPath("//div[@class='logged-user-w']//div[@class='logged-user-i']"));
        public IWebElement FinancialOverviewHeader => driver.FindElement(By.XPath("//h6[@class='element-header' and normalize-space()= 'Financial Overview']"));
        public ReadOnlyCollection<IWebElement> BalancesDisplay => driver.FindElements(By.XPath("//div[@class='element-balances']//child::div"));
        public IWebElement RecentTransactions => driver.FindElement(By.XPath("//h6[@class='element-header' and normalize-space()= 'Recent Transactions']"));
        public ReadOnlyCollection<IWebElement> TableColumnHeaders => driver.FindElements(By.XPath("//table[@class='table table-padded']//thead//tr//th"));
        public IWebElement TableBody => driver.FindElement(By.XPath("//table[@class='table table-padded']//following::tbody"));









    }
}
