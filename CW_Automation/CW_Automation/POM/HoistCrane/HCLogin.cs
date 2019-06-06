using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Configuration;

namespace CW_Automation.POM.HoistCrane
{
    public class HCLogin
    {
        // string keyvalue = Properties.Settings.Default.;
        readonly String  hcURL = Properties.Settings.Default.HCURL;
        readonly String strUserEmailAddress = Properties.Settings.Default.HCEMAIL;
        readonly String strUserPassword = Properties.Settings.Default.HCPASSWORD;

        readonly private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "Email")]
        public IWebElement txtEmailAddress;

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword;

        [FindsBy(How = How.Id, Using = "loginbutton")]
        public IWebElement btnSubmit;

        [Obsolete]
        public HCLogin(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void LoginToHoistAndCrane()
        {

            driver.Navigate().GoToUrl(hcURL);
            Assert.IsTrue(driver.Title == "Hoist & Crane");

            if (txtEmailAddress.Displayed)
            {
                txtEmailAddress.SendKeys(strUserEmailAddress);
            }
            else
            {
                driver.Manage().Logs.GetLog(LogType.Browser);
                Console.WriteLine("Email textbox is not visible, Failing the test");
                driver.Close();
            }
            if (txtPassword.Displayed)
            {
                txtPassword.SendKeys(strUserPassword);
            }
            else
            {
                driver.Manage().Logs.GetLog(LogType.Browser);
                Console.WriteLine("Password textbox is not visible, Failing the test");
                driver.Close();
            }

            if (btnSubmit.Displayed)
            {
                btnSubmit.Click();
            }
            else
            {
                driver.Manage().Logs.GetLog(LogType.Browser);
                Console.WriteLine("Submit button is not visible, Failing the test");
                driver.Close();
            }

           // driver.Manage().Logs.
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"D:\Users\vbhapkar\source\repos\CW_Automation\CW_Automation\ScreenPrints\screen.jpeg", ScreenshotImageFormat.Jpeg);
        }

    }
}
