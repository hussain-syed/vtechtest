using FluentAssertions;
using TechTalk.SpecFlow;

namespace ValtechUiAutomation.Features.HomePage
{
    [Binding]
    [Scope(Feature = "HomePage")]
    public class Steps
    {
        private readonly Valtech.HomePage _homePage;

        public Steps(Valtech.HomePage homePage)
        {
            _homePage = homePage;
        }

        [Given(@"I launch a browser")]
        public void GivenILaunchABrowser()
        {
        }

        [When(@"I navigate to Valtech homepage")]
        public void WhenINavigateToValtechHomepage()
        {
            _homePage.Navigate();
        }

        [Then(@"I see Latest News section")]
        public void ThenISeeLatestNewsSection()
        {
            _homePage.LatestNewsLabel.Should().NotBeNull("cant find Latest news section");
            _homePage.LatestNewsLabel.Text.Should().Be("LATEST NEWS");
        }

        [Then(@"I see (.*) tab")]
        public void ThenISeeWorkTab(string tabeName)
        {
            switch (tabeName)
            {
                case "WORK":
                    _homePage.WorkTab.Should().NotBeNull("cant find Work tab");
                    _homePage.WorkTab.Text.Should().Be("WORK");
                    break;

                case "SERVICES":
                    _homePage.ServicesTab.Should().NotBeNull("cant find Services tab");
                    _homePage.ServicesTab.Text.Should().Be("SERVICES");
                    break;

                case "CAREERS":
                    _homePage.CareersTab.Should().NotBeNull("cant find careers tab");
                    _homePage.CareersTab.Text.Should().Be("CAREERS");
                    break;

                default:
                    throw new System.NotImplementedException();
            }
        }
    }
}