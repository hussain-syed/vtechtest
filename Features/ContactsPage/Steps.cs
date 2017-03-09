using FluentAssertions;
using TechTalk.SpecFlow;

namespace ValtechUiAutomation.Features.ContactsPage
{
    [Binding]
    [Scope(Feature = "ContactsPage")]
    public class Steps
    {
        private readonly Valtech.HomePage _homePage;
        private readonly Valtech.ContactsPage _contactsPage;

        public Steps(Valtech.HomePage homePage, Valtech.ContactsPage contactsPage)
        {
            _homePage = homePage;
            _contactsPage = contactsPage;
        }

        [Given(@"I am on HomePage of Valtech")]
        public void GivenIAmOnHomePageOfValtech()
        {
            _homePage.Navigate();
        }

        [When(@"I navigate to Contacts page")]
        public void WhenINavigateToContactspage()
        {
            _homePage.ContactsButton.Click();
        }

        [Then(@"I find (.*) locations for Valtech offices")]
        public void ThenIAssertTheLocationsForValtechOffices(int count)
        {
            _contactsPage.ContactOfficesList().Count.Should().Be(count);
        }
    }
}