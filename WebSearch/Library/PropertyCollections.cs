using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebSearch
{   
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        ClassName,
        XPath
    }

    class PropertyCollections
    {
        public static IWebDriver driver {get; set;}
    }

}
