using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using GoogleSearch.PageObjects;



namespace GoogleSearch
{
    enum IdentificationType
    {
        Id,
        Name,
        LinkText,
        ClassName,
        CssSelector,
    }
    class CustomMethods
    {
        //Enter Text into a field
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        // public static void EnterText(string element, string value, IdentificationType elementType)
        // {
        //     if (elementType == IdentificationType.Id)
        //     GlobalProperties.driver.FindElement(By.Id(element)).SendKeys(value);
        //     if (elementType == IdentificationType.Name)
        //     GlobalProperties.driver.FindElement(By.Name(element)).SendKeys(value);
        // }

        //Click a field or element
        public static void Click(IWebElement element)
        {
            element.Click();
        }

        // public static void Click(string element, IdentificationType elementType)
        // {
        //     if (elementType == IdentificationType.Id)
        //     GlobalProperties.driver.FindElement(By.Id(element)).Click();
        //     if (elementType == IdentificationType.Name)
        //     GlobalProperties.driver.FindElement(By.Name(element)).Click();
        //     if (elementType == IdentificationType.LinkText)
        //     GlobalProperties.driver.FindElement(By.LinkText(element)).Click();
        // }

        // public static void ClickLink(string element, IdentificationType elementType)
        // {
        //     if (elementType == IdentificationType.LinkText)
        //     GlobalProperties.driver.FindElement(By.LinkText(element)).Click();
        // }
    }
    
}