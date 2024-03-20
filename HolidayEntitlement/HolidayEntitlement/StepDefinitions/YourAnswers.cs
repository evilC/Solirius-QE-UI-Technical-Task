// Steps for the "Your Answers" DL at the bottom of pages
using FluentAssertions;
using Microsoft.Playwright;

namespace HolidayEntitlement.StepDefinitions
{
    [Binding]
    public class YourAnswers
    {
        private readonly IPage _browser;

        public YourAnswers(Hooks.Hooks hooks)
        {
            _browser = hooks.Browser;
        }

        [Then(@"the last answer should read '(.*)' and '(.*)'")]
        public async Task TheLastAnswerShouldReadTEXTAndTEXT(string title, string desc)
        {
            var lastAnswer = _browser.Locator("#content > div > div > div > dl > div").Last;
            var titleText = await lastAnswer.Locator("dt").TextContentAsync();
            titleText.Should().Be(title);
            var descText = await lastAnswer.Locator("dd").First.TextContentAsync();
            descText.Should().Be(desc);
        }
    }
}
