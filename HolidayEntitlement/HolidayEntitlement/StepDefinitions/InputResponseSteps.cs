// Steps for any page which requires a typed response
// eg Number of hours or days worked, or entering a date
using HolidayEntitlement.Pages;

namespace HolidayEntitlement.StepDefinitions
{
    [Binding]
    public class InputResponseSteps
    {
        private readonly Common _common;
        private readonly DecimalResponsePage _daysPerWeek;
        private readonly DateResponsePage _datePage;

        public InputResponseSteps(Hooks.Hooks hooks,
            Common common,
            DecimalResponsePage daysPerWeek,
            DateResponsePage employmentStartDate)
        {
            _common = common;
            _daysPerWeek = daysPerWeek;
            _datePage = employmentStartDate;
        }

        [When(@"the user enters '(.*)' into the 'Number of (days|hours) worked per week' input")]
        public async Task WhenTheUserEntersNUMBERIntoTheNumberOfDaysWorkedPerWeekInput(decimal number, string hoursDays)
        {
            await _daysPerWeek.DecimalInput.FillAsync(number.ToString());
            await _common.ContinueButton.ClickAsync();
        }

        [When(@"the user enters the date '(.*)' as '(.*)'")]
        public async Task TheUserEntersDATEAsTheEmploymentStartDate(string dateStr, string fieldName)
        {
            var date = dateStr.Split('-');
            await _datePage.Day.FillAsync(date[0]);
            await _datePage.Month.FillAsync(date[1]);
            await _datePage.Year.FillAsync(date[2]);
            await _common.ContinueButton.ClickAsync();
        }


    }
}
