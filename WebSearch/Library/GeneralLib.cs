using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebSearch.Library
{
    class GeneralLib
    {
        public void Initialize()
        {
            PropertyCollections.driver = new ChromeDriver();
            PropertyCollections.driver.Navigate().GoToUrl("http://google.com");
            Console.WriteLine("Init:Google page loaded");
        }

        public void MatchText(string text)
        {
            //Load the links into list
            IList<IWebElement> list = PropertyCollections.driver.FindElements(By.XPath("//div/h3"));
            Console.WriteLine("Total number of links displayed is : " + list.Count);
            //Loop the list of links
            for (int start = 1; start < list.Count; start++)
            {   //Get forth link value
                String value = list[start].Text.ToLower();

                if (value.Contains(text.ToLower()))
                {
                    Console.WriteLine(start + " Link is matching with search text : " + list[start].Text);
                }
                else
                {
                    Console.WriteLine(start + " Link is NOT matching with search text : " + list[start].Text);
                }
            }
        }

        public void ClearBrwoser()
        {
            PropertyCollections.driver.Close();
            Console.WriteLine("Test cleanup:Browse closed");
        }
    }
}
