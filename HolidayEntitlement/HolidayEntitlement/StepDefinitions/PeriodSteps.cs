// Steps for the period (full year, part way through a year etc)
using HolidayEntitlement.Pages;

namespace HolidayEntitlement.StepDefinitions
{
    [Binding]
    public class PeriodSteps
    {
        private readonly Common _common;
        private readonly PeriodPage _period;

        public PeriodSteps(Common common,
            PeriodPage period)
        {
            _common = common;
            _period = period;
        }

        [When(@"the user selects 'for a full leave year'")]
        public async Task WhenTheUserClicksFullYear()
        {
            await _period.FullYearRadio.ClickAsync();
            await _common.ContinueButton.ClickAsync();
        }

        [When(@"the user selects 'for someone starting part way through a leave year'")]
        public async Task WhenTheUserClicksStartingPartWay()
        {
            await _period.StartingPartWayRadio.ClickAsync();
            await _common.ContinueButton.ClickAsync();
        }

        [When(@"the user selects 'for someone leaving part way through a leave year'")]
        public async Task WhenTheUserClicksLeavingPartWay()
        {
            await _period.LeavingPartWayRadio.ClickAsync();
            await _common.ContinueButton.ClickAsync();
        }

        [When(@"the user selects 'for someone starting and leaving part way through a leave year'")]
        public async Task WhenTheUserClicksStartingAndLeavingPartWay()
        {
            await _period.StartingAndLeavingPartWayRadio.ClickAsync();
            await _common.ContinueButton.ClickAsync();
        }
    }
}
