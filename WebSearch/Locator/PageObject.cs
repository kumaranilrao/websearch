using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebSearch
{
    class PageObject
    {
        public PageObject()
        {
            PageFactory.InitElements(PropertyCollections.driver, this);
        }
        
        [FindsBy(How =How.Name,Using ="q")]
        public IWebElement TxtSearch { get; set; }
    }
}
