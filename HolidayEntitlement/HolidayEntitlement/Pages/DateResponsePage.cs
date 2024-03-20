// Page Object for any page on which a date is entered
using Microsoft.Playwright;

namespace HolidayEntitlement.Pages
{
    public class DateResponsePage
    {
        private readonly IPage _browser;
        public ILocator Day => _browser.Locator("#response-0");
        public ILocator Month => _browser.Locator("#response-1");
        public ILocator Year => _browser.Locator("#response-2");

        public DateResponsePage(Hooks.Hooks hooks)
        {
            _browser = hooks.Browser;
        }
    }
}
