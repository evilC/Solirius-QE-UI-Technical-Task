// Page Object for the results page ("Is the holiday entitlement based on")
using Microsoft.Playwright;

namespace HolidayEntitlement.Pages
{
    public class BasePage
    {
        public readonly string Url = $"{Site.Url}/y";
        private readonly IPage _browser;

        public ILocator DaysWorkedPerWeekRadio => _browser.Locator("#response-0");
        public ILocator HoursWorkedPerWeekRadio => _browser.Locator("#response-1");
        public ILocator CasualRadio => _browser.Locator("#response-2");
        public ILocator AnnualisedRadio => _browser.Locator("#response-3");
        public ILocator CompressedRadio => _browser.Locator("#response-4");
        public ILocator ShiftsRadio => _browser.Locator("#response-5");


        public BasePage(Hooks.Hooks hooks)
        {
            _browser = hooks.Browser;
        }

    }
}

