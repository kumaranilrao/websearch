using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebSearch
{
    class SetMethods
    {
        //Enter Text
        public static void SetText(string element,string value,PropertyType type)
        {
            if (type == PropertyType.Id)
                PropertyCollections.driver.FindElement(By.Id(element)).SendKeys(value);
            if (type == PropertyType.Name)
                PropertyCollections.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //click button,chekbox 
        public static void Click(string element,PropertyType type)
        {
            if (type == PropertyType.Id)
                PropertyCollections.driver.FindElement(By.Id(element)).Click();
            if (type == PropertyType.Name)
                PropertyCollections.driver.FindElement(By.Name(element)).Click();
            if (type == PropertyType.XPath)
                PropertyCollections.driver.FindElement(By.XPath(element)).Click();
        }

        //Drop down
        public static void SelectDropDown(string element, string value, PropertyType type)
        {
            if (type == PropertyType.Id)
                new SelectElement(PropertyCollections.driver.FindElement(By.Id(element))).SelectByText(value);
            if (type == PropertyType.Name)
                new SelectElement(PropertyCollections.driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
