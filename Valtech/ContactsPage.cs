using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;

namespace ValtechUiAutomation.Valtech
{
    public class ContactsPage
    {
        private readonly IWebDriver _webDriver;

        public ContactsPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            PageFactory.InitElements(_webDriver, this);
        }

        public ReadOnlyCollection<IWebElement> ContactOfficesList()
        {
            return _webDriver.FindElement(By.ClassName("contactbody"))
                             .FindElements(By.TagName("LI"));
        }
    }
}