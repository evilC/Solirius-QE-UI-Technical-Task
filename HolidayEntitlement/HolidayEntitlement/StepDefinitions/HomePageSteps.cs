// Steps for the Home (Landing) page
using FluentAssertions;
using HolidayEntitlement.Pages;
using Microsoft.Playwright;

namespace HolidayEntitlement.StepDefinitions
{
    [Binding]
    public class HomePageSteps
    {
        private readonly IPage _browser;
        private readonly HomePage _homePage;
        private readonly BasePage _basePage;

        public HomePageSteps(Hooks.Hooks hooks, HomePage homePage, BasePage basePage)
        {
            _browser = hooks.Browser;
            _homePage = homePage;
            _basePage = basePage;
        }

        [Given(@"the user is on the Homepage")]
        public async Task GivenTheUserIsOnTheHomepage()
        {
            await _browser.GotoAsync(_homePage.Url);
        }

        [When(@"the user clicks 'Start now'")]
        public async Task WhenTheUserClicksStartNow()
        {
            await _homePage.StartNowButton.ClickAsync();
        }

        [Then(@"the browser should navigate to the base page")]
        public Task ThenTheBrowserShouldNavigateToTheBasePage()
        {
            _browser.Url.Should().Be(_basePage.Url);
            return Task.CompletedTask;
        }
    }
}