// Steps for Error related items
using FluentAssertions;
using HolidayEntitlement.Pages;

namespace HolidayEntitlement.StepDefinitions
{
    [Binding]
    public class ErrorSteps
    {
        private readonly Common _common;

        public ErrorSteps(Common common)
        {
            _common = common;
        }

        [Then(@"the error element should be shown, indicating that there is a problem")]
        public async Task ThenAnErrorShouldBeShown()
        {
            (await _common.ErrorHeading.IsVisibleAsync()).Should().Be(true);
            (await _common.ErrorHeading.TextContentAsync()).Should().Contain("There is a problem");
        }

        [Then(@"the error should say that there are only 7 days in a week")]
        public async Task ThenTheErrorShouldSayThatThereAreOnly7DaysInAWeek()
        {
            (await _common.ErrorDescription.TextContentAsync()).Should().Be(
                "There are only 7 days in a week. Please check and enter a correct value.");
        }

        [Then(@"the error should say that you must answer this question")]
        public async Task ThenTheErrorShouldSayThatYouMustAnswerThisQuestion()
        {
            (await _common.ErrorDescription.TextContentAsync()).Should().Be(
                "Please answer this question");
        }

        [Then(@"the error should say that the leave year start date must be earlier than your employment start date of '(.*)'")]
        public async Task ThenTheErrorShouldSayThatTheLeaveYearStartDateMustBeEarlierThanYourEmploymentStartDateOfDATE(string date)
        {
            (await _common.ErrorDescription.TextContentAsync()).Should().Contain(
                $"Your leave year start date must be earlier than your employment start date of {date}.");
        }
    }
}
