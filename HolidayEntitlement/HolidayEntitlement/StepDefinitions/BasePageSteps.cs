// Steps for the results page ("Is the holiday entitlement based on")
using HolidayEntitlement.Pages;
using Microsoft.Playwright;

namespace HolidayEntitlement.StepDefinitions
{
    [Binding]
    public class BasePageSteps
    {
        private readonly IPage _browser;
        private readonly Common _common;
        private readonly BasePage _basePage;

        public BasePageSteps(Hooks.Hooks hooks, 
            Common common, 
            BasePage basePage)
        {
            _browser = hooks.Browser;
            _common = common;
            _basePage = basePage;
        }

        // === GIVEN ===
        [Given(@"the user is on the Base page")]
        public async Task GivenTheUserIsOnTheBasePage()
        {
            await _browser.GotoAsync(_basePage.Url);
        }

        [Given(@"the user is on the 'days worked per week' page")]
        public async Task GivenTheUserIsOnTheDaysPerWeekPage()
        {
            await _browser.GotoAsync(_common.DaysWorkedPerWeekUrl);
        }

        // === WHEN ===
        [When(@"the user selects 'days worked per week'")]
        public async Task WhenTheUserSelectsDaysWorkedPerWeek()
        {
            await _basePage.DaysWorkedPerWeekRadio.ClickAsync();
            await _common.ContinueButton.ClickAsync();
        }

        [When(@"the user selects 'hours worked per week'")]
        public async Task WhenTheUserSelectsHoursWorkedPerWeek()
        {
            await _basePage.HoursWorkedPerWeekRadio.ClickAsync();
            await _common.ContinueButton.ClickAsync();
        }

        [When(@"the user selects 'casual or irregular hours, including zero hours contracts'")]
        public async Task WhenTheUserSelectsCasualHours()
        {
            await _basePage.CasualRadio.ClickAsync();
            await _common.ContinueButton.ClickAsync();
        }

        [When(@"the user selects 'annualised hours'")]
        public async Task WhenTheUserSelectsAnnualisedHours()
        {
            await _basePage.AnnualisedRadio.ClickAsync();
            await _common.ContinueButton.ClickAsync();
        }

        [When(@"the user selects 'compressed hours'")]
        public async Task WhenTheUserSelectsCompressedHours()
        {
            await _basePage.CompressedRadio.ClickAsync();
            await _common.ContinueButton.ClickAsync();
        }
    }
}