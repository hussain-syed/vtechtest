using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace ValtechUiAutomation.Valtech
{
    public class HomePage
    {
        private readonly IWebDriver _webDriver;
        private readonly string url = @"https://www.valtech.com/";

        public HomePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            PageFactory.InitElements(_webDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"navigationMenuWrapper\"]/div/ul/li[2]/a")]
        public IWebElement WorkTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"navigationMenuWrapper\"]/div/ul/li[3]/a")]
        public IWebElement ServicesTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"navigationMenuWrapper\"]/div/ul/li[6]/a")]
        public IWebElement CareersTab { get; set; }

        [FindsBy(How = How.Id, Using = "contacticon")]
        public IWebElement ContactsButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "news-post__listing-header")]
        public IWebElement LatestNewsLabel { get; set; }

        public void Navigate()
        {
            _webDriver.Navigate().GoToUrl(url);
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10))
                            .Until(ExpectedConditions.ElementIsVisible(By.ClassName("navigation__menu__bg")));
        }
    }
}