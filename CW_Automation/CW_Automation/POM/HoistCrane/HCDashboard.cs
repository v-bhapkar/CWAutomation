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
    public class HCDashboard
    {
        readonly private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "m1")]
        public IWebElement linkDashboard;

        [FindsBy(How = How.Id, Using = "m90")]
        public IWebElement linkInspection;

        [FindsBy(How = How.Id, Using = "m91")]
        public IWebElement linkEquipment;

        [FindsBy(How = How.Id, Using = "m95")]
        public IWebElement linkSubmission;

        [FindsBy(How = How.Id, Using = "m5")]
        public IWebElement linkDataSource;

        [FindsBy(How = How.Id, Using = "f1")]
        public IWebElement linkGroupCVS;

        [FindsBy(How = How.Id, Using = "f2")]
        public IWebElement linkEquipmentType;

        [FindsBy(How = How.Id, Using = "m2")]
        public IWebElement linkUsers;

        [FindsBy(How = How.Id, Using ="m96")]
        public IWebElement linkJobList;

        [FindsBy(How = How.Id, Using = "m11")]
        public IWebElement linkCettiWorks;

        [FindsBy(How = How.Id, Using = "m12")]
        public IWebElement linkLog;

        [Obsolete]
        public HCDashboard(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            
        }

        // Function to click on Dashboard link
        public void ClickOnDashboard()
        {
            if (linkDashboard.Displayed)
            {
                linkDashboard.Click();
            }
            else
            {
                Console.WriteLine("Dashboard link is not visible");
                driver.Quit();
            }
        }

        // Function to click on Dashboard link
        public void ClickOnEquipment()
        {
            if (linkDashboard.Displayed)
            {
                linkEquipment.Click();
            }
            else
            {
                Console.WriteLine("Dashboard link is not visible");
                driver.Quit();
            }
        }




    }

       








        


    
}
