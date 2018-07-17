using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebSearch.Library;

namespace WebSearch 
{
    [Binding]

    public sealed class StepDefinition
    {   //programe object
        Program pgm = new Program();
        GeneralLib gbl = new GeneralLib();
        [Given(@"I loaded web browser is on the Google page")]
        public void GivenILoadedWebBrowserIsOnTheGooglePage()
        {
            //init
            gbl.Initialize();
        }

        [When(@"I search text ""(.*)"" is entered")]
        public void WhenISearchTextIsEntered(string text)
        {   //Enter the search text
            pgm.SearchText(text);
        }

        [Then(@"results for ""(.*)"" are shown")]
        public void ThenResultsForAreShown(string text)
        {
            //Validate search text link listed
            gbl.MatchText(text);
            //close Browser
            gbl.ClearBrwoser();
        }

        [When(@"results for ""(.*)"" are shown")]
        public void WhenResultsForAreShown(string text)
        {   //Validate search text link listed
            gbl.MatchText(text);
        }

        [Then(@"the (.*)th link result shown")]
        public void ThenTheThLinkResultShown(int number)
        {   //Search the spacific number link
            pgm.DisplayLink(number);
            //close Browser
            gbl.ClearBrwoser();
        }

        [Then(@"the result do not include ""(.*)""")]
        public void ThenTheResultDoNotInclude(string text)
        {
            //Others search text should not display
            gbl.MatchText(text);
            //close Browser
            gbl.ClearBrwoser();
        }

        [Given(@"clear all the browser")]
        public void GivenClearAllTheBrowser()
        {
            //clear the browser
            gbl.ClearBrwoser();
        }


    }
}
