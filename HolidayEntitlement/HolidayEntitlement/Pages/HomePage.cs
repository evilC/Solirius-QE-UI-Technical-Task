// Page Object for the Home (Landing) page
using Microsoft.Playwright;

namespace HolidayEntitlement.Pages
{
    public class HomePage
    {
        private readonly IPage _browser;
        public readonly string Url = Site.Url;

        public ILocator StartNowButton => _browser.Locator("#content > div:nth-child(2) > div.govuk-grid-column-two-thirds > article > section > a");

        public HomePage(Hooks.Hooks hooks)
        {
            _browser = hooks.Browser;
        }
    }
}
