using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebSearch
{
    class Program
    {
        static void Main(string[] args)
        {}

        public void SearchText(string text)
        {
            //Object for the page object
            PageObject page = new PageObject();
            page.TxtSearch.SendKeys(text);
            page.TxtSearch.SendKeys(Keys.Enter);
            Console.WriteLine("Search key value is : " + GetMethods.GetText("q", PropertyType.Name));

        }
        
        public void DisplayLink(int number)
        {
            //Load the links into list
            IList<IWebElement> list = PropertyCollections.driver.FindElements(By.XPath("//div/h3"));
            Console.WriteLine("Total number of links displayed is : " + list.Count);
            //Loop the list of links
            for (int start = 1; start < list.Count; start++)
            {   //Get forth link value
                if (start == number)
                {
                    Console.WriteLine(start + " Link is : " + list[start].Text);
                    break;
                }
            }
        }
        
       

    }
}
