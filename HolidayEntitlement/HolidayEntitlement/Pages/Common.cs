// Page Objects common to all pages
using Microsoft.Playwright;

namespace HolidayEntitlement.Pages
{
    public class Common
    {
        private readonly IPage _browser;

        public readonly string DaysWorkedPerWeekUrl = $"{Site.Url}/y/days-worked-per-week";

        public ILocator ErrorSummary => _browser.Locator("#error-summary");
        public ILocator ErrorHeading => _browser.Locator("#error-summary > div > h2");
        public ILocator ErrorDescription => _browser.Locator("#error-summary > div > div > ul > li > a");

        public ILocator ContinueButton => _browser.Locator("#current-question > button");

        public Common(Hooks.Hooks hooks)
        {
            _browser = hooks.Browser;
        }
        
    }
}
