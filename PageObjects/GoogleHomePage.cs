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
    class GoogleHomePage
    {
        // private WebDriverWait delay;
        public GoogleHomePage()
        {
        //     //Initiate the page and its objects within the page; timer delay is optional
            PageFactory.InitElements(GlobalProperties.driver, this);
            // delay = new WebDriverWait(GlobalProperties.driver, TimeSpan.FromSeconds(5));
        }

        // Alternative method using LINQ since seleniumextras.pageobjects still incompatible with .net 2.0
        // private IWebDriver driver;

        // public GoogleHomePage(IWebDriver driver) => _driver = driver;

        // IWebElement SearchBox => driver.FindElementByName("q");

        // IWebElement SearchButton => driver.FindElementByName("btnK");
        

        //Declare the search box and button objects on [this] page

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement SearchButton { get; set; }

        // [FindsBy(How = How.LinkText, Using = "FAQ |Trunk Club‎")]
        // public IWebElement SearchResult { get; set; }


        public ResultsPage Search(string SearchEntry)
        {
            SearchBox.SendKeys(SearchEntry);

            SearchButton.Click();

            return new ResultsPage();
            // return new ResultsPage(driver);

        }
    }
}

