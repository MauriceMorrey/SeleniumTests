using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;


namespace GoogleSearch.PageObjects
{
    class ResultsPage
    {
        // private IWebDriver driver;
        // public ResultsPage(IWebDriver driver)
        // {
        //     this.driver = driver;
        //     PageFactory.InitElements(driver, this);
        // }

        public ResultsPage()
        {
            PageFactory.InitElements(GlobalProperties.driver, this);
        }

        //Find FAQ link tag 
        [FindsBy(How = How.LinkText, Using = "FAQ |Trunk Club")]
        public IWebElement FAQLink { get; set; }


        //post pagefactory method possibly?
        // private IWebDriver driver;

        // public ResultsPage(IWebDriver driver) => _driver = driver;

        // IWebElement FAQLink => driver.FindElementByLinkText("FAQ |Trunk Club");

        //Click on link to open
        public void OpenFAQLink()
        {
            FAQLink.Click();
        }
    }
}