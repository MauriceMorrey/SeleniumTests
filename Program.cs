using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using GoogleSearch.PageObjects;
// using WebDriverChromeDriver;
// using WebDriver.ChromeDriver;



namespace GoogleSearch
{
    class Program
    {

        //Create the reference for our browser
            // IWebDriver driver = new ChromeDriver("C:\\Users\\Mac\\Downloads");

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //Create the reference for our browser
            // IWebDriver driver = new ChromeDriver("C:\\Users\\Mac\\Downloads");


            // //Navigate to Google Page
            // driver.Navigate().GoToUrl("https://www.google.com/");

            // //Find the Element we want to use
            // IWebElement element = driver.FindElement(By.Name("q"));

            // //Perform operations
            // element.SendKeys("What is Trunk Club?");

            // //Close browser
            // driver.Close();


        }
            [SetUp]
            public void InitializePage()
            {
                //Create the reference for our browser
                GlobalProperties.driver = new ChromeDriver("C:\\Users\\Mac\\Downloads");

                 //Navigate to Google Home Page
                GlobalProperties.driver.Navigate().GoToUrl("https://www.google.com/");
                System.Console.WriteLine("Successfully Opened page");
            }

            [Test]
            public void ExecuteTest()
            {
                //Method 1
                //Find the Element we want to use
                // IWebElement element = GlobalProperties.driver.FindElement(By.Name("q"));
                // System.Console.WriteLine("Successfully found Element");

                // //Perform operations
                // element.SendKeys("What is Trunk Club?");
                // System.Console.WriteLine("Successfully mimicked a keyboard..Ha!");

                 //Method 2   
                //Enter Text by calling the EnterText method from our custom methods
                // CustomMethods.EnterText("q", "What is Trunk Club?", IdentificationType.Name);

                //Perform click event
                // CustomMethods.Click("btnK", IdentificationType.Name);

                //Perform click event
                // CustomMethods.ClickLink("FAQ |Trunk Club", IdentificationType.LinkText);
                

                //Method 3
                //Using Selenium Inbuilt methods and PageFactory

                //First initialize the page and all its objects by calling its reference
                GoogleHomePage SearchPage = new GoogleHomePage();

                // //perform page operations using the variable page
                // searchPage.SearchBox.SendKeys("What is Trunk Club?");

                // searchPage.SearchButton.Click();
               
                //Input search text and open target link text
                ResultsPage SearchResults = SearchPage.Search("What is Trunk Club?");
                SearchResults.OpenFAQLink();

            }

            [TearDown]
            public void CleanUp()
            {
                //Close browser
                GlobalProperties.driver.Close();
                System.Console.WriteLine("Bam! Door slammed shut!");
            }
    }
}
