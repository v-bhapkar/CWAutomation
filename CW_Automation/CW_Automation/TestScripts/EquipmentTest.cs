using CW_Automation.POM.HoistCrane;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace CW_Automation.TestScripts
{

    public class EquipmentTest
    {

        private IWebDriver driver;
        HCLogin login = null;
        HCDashboard dashboard = null;
        HCEquipment equipment = null;
        
        [SetUp]
        [Obsolete]
        public void SetUp()
        {
            //String hcURL = ConfigurationManager.AppSettings["HCURL"];
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            login = new HCLogin(driver);
            dashboard = new HCDashboard(driver);
            equipment = new HCEquipment(driver);

        }

        [Test]
        [Obsolete]
        public void CreateSlingsWebEquipment()
        {

            login.LoginToHoistAndCrane();
            dashboard.ClickOnEquipment();
            equipment.clickOnAddNewEquipment();
        }

        [TearDown]
        public void TearDown()
        {
            //   driver.Close();
        }




    }
}
