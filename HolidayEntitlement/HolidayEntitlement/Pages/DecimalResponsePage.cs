// Page Object for any page which a number is entered
using Microsoft.Playwright;

namespace HolidayEntitlement.Pages
{
    public class DecimalResponsePage
    {
        private readonly IPage _browser;
        public ILocator DecimalInput => _browser.Locator("#response");

        public DecimalResponsePage(Hooks.Hooks hooks)
        {
            _browser = hooks.Browser;
        }
    }
}
