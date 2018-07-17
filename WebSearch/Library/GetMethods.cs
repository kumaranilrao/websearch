using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebSearch
{
    class GetMethods
    {
        public static string GetText(string element, PropertyType type)
        {
            if (type == PropertyType.Id)
                return PropertyCollections.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (type == PropertyType.Name)
                return PropertyCollections.driver.FindElement(By.Name(element)).GetAttribute("value");
            else
                return string.Empty;
        }

        
    }
}
