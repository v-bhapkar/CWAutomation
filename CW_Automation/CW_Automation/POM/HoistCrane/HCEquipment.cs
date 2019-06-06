using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CW_Automation.POM.HoistCrane
{
    class HCEquipment
    {
        private IWebDriver driver;

        // Button Add New Equipment

        [FindsBy(How = How.XPath, Using = "//a[contains(text() , 'Add New Equipment')]")]
        IWebElement btnAddNewEquipment;

        // Button Export to Excel

        [FindsBy(How = How.XPath, Using = "//a[contains(text() , 'Export to Excel')]")]
        IWebElement btnExportToExcel;

        // button Sensor Data

        [FindsBy(How = How.XPath, Using = "//a[contains(text() , ' Sensor Data')]")]
        IWebElement btnSensorData;


        // ************************** Add new equipment form welements *************

        [FindsBy(How = How.Id, Using = "CorporateName")]
        IWebElement txtCorporateName;

        [FindsBy(How = How.Id, Using = "crane_Number")]
        IWebElement txtCraneNumber;

        [FindsBy(How = How.Id, Using = "InspectionNumber")]
        IWebElement txtInspectionNumber;

        [FindsBy(How = How.Id, Using = "DateEntered")]
        IWebElement txtDateEntered;





        //ctor
        public HCEquipment(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        // Method to Click on Add new Equipment

        public void clickOnAddNewEquipment()
        {
            if (btnAddNewEquipment.Displayed)
            {
                btnAddNewEquipment.Click();
            }
            else
            {
                driver.Manage().Logs.GetLog(LogType.Browser);
                Console.WriteLine("Button Add new equipment is not visible, Failing the test");
                driver.Close();
            }
        }


        // Method to create an Slings Web

        public void addEquipmentSlingsWeb(String strCorporateName, String strEquipmentNumber, String strEquipmentType, String strArea, String strLocation)
        {




        }

    }
}
