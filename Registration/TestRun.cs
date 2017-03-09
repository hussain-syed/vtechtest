using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace ValtechUiAutomation.Registration
{
    [Binding]
    public class TestRun
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _webDriver;

        public TestRun(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [Given(@"I launch a (.*) browser")]
        public void SelectingWebDriver(string browser)
        {
            //var browser = ConfigurationManager.AppSettings["Browser"];
            switch (browser.ToUpper())
            {
                case "CHROME":
                    _webDriver = new ChromeDriver();
                    break;

                case "FIREFOX":
                    _webDriver = new FirefoxDriver();
                    break;

                default:
                    throw new NotImplementedException();
            }
            _objectContainer.RegisterInstanceAs<IWebDriver>(_webDriver);
        }

        [AfterScenario]
        public void DisposingWebDriver()
        {
            _webDriver.Close();
            _webDriver.Dispose();
        }
    }
}