// Steps for the Results page
using FluentAssertions;
using HolidayEntitlement.Pages;

namespace HolidayEntitlement.StepDefinitions
{
    [Binding]
    public class ResultSteps
    {
        private readonly ResultPage _result;

        public ResultSteps(ResultPage result)
        {
            _result = result;
        }

        [Then(@"the holiday entitlement should read '(.*)' days")]
        public async Task ThenTheHolidayEntitlementShouldReadNUMBERDays(decimal number)
        {
            var entitlement = await _result.ResultHoursDaysLocator.TextContentAsync();
            entitlement.Should().Be($"The statutory holiday entitlement is {number} days holiday.");
        }

        [Then(@"the holiday entitlement should read '(.*)' hours")]
        public async Task ThenTheHolidayEntitlementShouldReadNUMBERHours(decimal number)
        {
            var entitlement = await _result.ResultHoursDaysLocator.TextContentAsync();
            entitlement.Should().Be($"The statutory entitlement is {number} hours holiday.");
        }

        [Then(@"the holiday entitlement should read '(.*)' weeks")]
        public async Task ThenTheHolidayEntitlementShouldReadNUMBERWeeks(decimal number)
        {
            var entitlement = await _result.ResultWeeksLocator.TextContentAsync();
            entitlement.Should().Be($"The statutory holiday entitlement is {number} weeks holiday.");
        }

        [Then(@"the holiday entitlement should read '(.*)' hours, '(.*)' minutes, rather '(.*)' hours, '(.*)' minutes")]
        public async Task ThenTheHolidayEntitlementShouldReadNUMBERWeeks(decimal hours, decimal mins, decimal rHours, decimal rMins)
        {
            var entitlement = await _result.ResultCompressedLocator.TextContentAsync();
            entitlement.Should().Be($"The statutory holiday entitlement is {hours} hours and {mins} minutes holiday for the year. Rather than taking a day’s holiday it’s {rHours} hour and {rMins} minutes holiday for each day otherwise worked.");
        }

    }
}
