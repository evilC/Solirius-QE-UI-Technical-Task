// Page object for period pages (full year, part way through a year etc)
using Microsoft.Playwright;

namespace HolidayEntitlement.Pages
{
    public class PeriodPage
    {
        private readonly IPage _browser;
        public ILocator FullYearRadio => _browser.Locator("#response-0");
        public ILocator StartingPartWayRadio => _browser.Locator("#response-1");
        public ILocator LeavingPartWayRadio => _browser.Locator("#response-2");
        public ILocator StartingAndLeavingPartWayRadio => _browser.Locator("#response-3");

        public PeriodPage(Hooks.Hooks hooks)
        {
            _browser = hooks.Browser;
        }
    }
}
